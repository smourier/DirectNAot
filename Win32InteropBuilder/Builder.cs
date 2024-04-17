using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices;
using System.Text.Json;
using Win32InteropBuilder.Languages;
using Win32InteropBuilder.Model;
using Win32InteropBuilder.Utilities;

namespace Win32InteropBuilder
{
    public class Builder
    {
        public static JsonSerializerOptions JsonSerializerOptions { get; } = new()
        {
            ReadCommentHandling = JsonCommentHandling.Skip,
            AllowTrailingCommas = true,
            Converters = { new EncodingConverter() }
        };

        public static void Run(string configurationPath, string winMdPath)
        {
            ArgumentNullException.ThrowIfNull(configurationPath);
            ArgumentNullException.ThrowIfNull(winMdPath);

            BuilderConfiguration? configuration;
            try
            {
                using var stream = File.OpenRead(configurationPath);
                configuration = JsonSerializer.Deserialize<BuilderConfiguration>(stream, JsonSerializerOptions);
                EnumBasedException<Win32InteropBuilderExceptionCode>.ThrowIfNull(Win32InteropBuilderExceptionCode.InvalidConfiguration, configuration);
            }
            catch (Exception ex)
            {
                throw new EnumBasedException<Win32InteropBuilderExceptionCode>(Win32InteropBuilderExceptionCode.InvalidConfiguration, ex);
            }

            if (configuration.BuilderTypeFilePath != null)
            {
                Assembly.LoadFrom(configuration.BuilderTypeFilePath);
            }

            if (configuration.Language?.TypeFilePath != null)
            {
                Assembly.LoadFrom(configuration.Language.TypeFilePath);
            }

            configuration.Language ??= new BuilderConfiguration.LanguageConfiguration();
            configuration.Language.TypeName ??= typeof(CSharpLanguage).AssemblyQualifiedName!;
            configuration.BuilderTypeName ??= typeof(Builder).AssemblyQualifiedName!;
            configuration.WinMdPath ??= Path.Combine(winMdPath, "Windows.Win32.winmd");
            configuration.OutputDirectoryPath ??= Path.GetFullPath(CommandLine.Current.GetNullifiedArgument(1) ?? Path.GetFileNameWithoutExtension(configurationPath));

            var builderType = Type.GetType(configuration.BuilderTypeName, true)!;
            var builder = (Builder)Activator.CreateInstance(builderType)!;

            var languageType = Type.GetType(configuration.Language.TypeName, true)!;
            var language = (ILanguage)Activator.CreateInstance(languageType)!;

            // reread file to configure per language
            using var stream2 = File.OpenRead(configurationPath);
            var configurationDic = JsonSerializer.Deserialize<Dictionary<string, object>>(stream2, JsonSerializerOptions);
            if (configurationDic?.TryGetValue(nameof(configuration.Language), out var languageConfig) == true &&
                languageConfig is JsonElement element &&
                element.ValueKind == JsonValueKind.Object &&
                element.TryGetProperty(language.Name, out var perLangConfig))
            {
                language.Configure(perLangConfig);
            }

            var context = builder.CreateBuilderContext(configuration, language);
            context.Logger = new ConsoleLogger();
            context.LogInfo($"Builder type name: {builder.GetType().FullName}");
            context.LogInfo($"WinMd path: {configuration.WinMdPath}");
            context.LogInfo($"Architecture: {configuration.Architecture}");
            context.LogInfo($"Language: {language.Name}");
            context.LogInfo($"Output path: {configuration.OutputDirectoryPath}");
            context.LogInfo($"Output encoding: {configuration.FinalOutputEncoding.WebName}");
            context.LogInfo($"Running {builderType!.FullName} builder...");
            context.LogInfo();
            builder.Build(context);
        }

        public virtual BuilderContext CreateBuilderContext(BuilderConfiguration configuration, ILanguage language) => new(configuration, language);

        public virtual void Build(BuilderContext context)
        {
            ArgumentNullException.ThrowIfNull(context);
            if (context.Configuration.WinMdPath == null)
                throw new ArgumentException(null, nameof(context));

            var arch = context.Configuration.Architecture;
            if (arch != Model.Architecture.X86 & arch != Model.Architecture.X64 && arch != Model.Architecture.Arm64)
                throw new EnumBasedException<Win32InteropBuilderExceptionCode>(Win32InteropBuilderExceptionCode.UnsupportedArchitecture, $"Architecture: {arch}");

            using var stream = File.OpenRead(context.Configuration.WinMdPath);
            using var pe = new PEReader(stream);
            context.MetadataReader = pe.GetMetadataReader();
            GatherTypes(context);
            GenerateTypes(context);
        }

        protected virtual void GatherTypes(BuilderContext context)
        {
            ArgumentNullException.ThrowIfNull(context);
            ArgumentNullException.ThrowIfNull(context.Configuration);
            ArgumentNullException.ThrowIfNull(context.MetadataReader);

            AddWellKnownTypes(context);
            var matches = new HashSet<BuilderType>();
            var reverses = new HashSet<BuilderType>();

            foreach (var typeDef in context.MetadataReader.TypeDefinitions.Select(context.MetadataReader.GetTypeDefinition))
            {
                var type = context.CreateBuilderType(typeDef);
                if (type == null)
                    continue;

                context.CurrentTypes.Push(type);
                try
                {
                    context.AllTypes[type.FullName] = type;
                    context.TypeDefinitions[type.FullName] = typeDef;

                    foreach (var match in context.Configuration.TypeInputs.Where(x => x.Matches(type)))
                    {
                        if (match.IsReverse)
                        {
                            reverses.Add(type);
                        }
                        else
                        {
                            matches.Add(type);
                        }
                    }
                }
                finally
                {
                    if (context.CurrentTypes.Pop() != type)
                        throw new InvalidOperationException();
                }
            }

            foreach (var match in reverses.ToArray())
            {
                matches.Remove(match);
            }

            foreach (var type in matches)
            {
                context.AddDependencies(type);
            }

            RemoveNonGeneratedTypes(context);
        }

        protected virtual void RemoveNonGeneratedTypes(BuilderContext context)
        {
            ArgumentNullException.ThrowIfNull(context);
            ArgumentNullException.ThrowIfNull(context.Configuration);
            ArgumentNullException.ThrowIfNull(context.Configuration.Generation);

            context.TypesToBuild.Remove(new BuilderType(FullName.IUnknown));

            if (context.Configuration.Generation.HandleToIntPtr)
            {
                RemoveHandleTypes(context);
            }
        }

        protected virtual void RemoveHandleTypes(BuilderContext context)
        {
            ArgumentNullException.ThrowIfNull(context);
            ArgumentNullException.ThrowIfNull(context.MetadataReader);
            foreach (var type in context.TypesToBuild.ToArray())
            {
                if (context.TypeDefinitions.TryGetValue(type.FullName, out var typeDef) &&
                    context.MetadataReader.IsHandle(typeDef, context.SignatureTypeProvider))
                {
                    context.TypesToBuild.Remove(type);
                }
            }
        }

        protected virtual void AddWellKnownTypes(BuilderContext context)
        {
            ArgumentNullException.ThrowIfNull(context);
            foreach (var kv in WellKnownTypes.All)
            {
                context.AllTypes[kv.Key] = kv.Value;
            }
        }

        protected virtual void AddMappedTypes(BuilderContext context)
        {
            ArgumentNullException.ThrowIfNull(context);
            context.MappedTypes[FullName.BOOL] = WellKnownTypes.SystemBoolean;
            context.MappedTypes[FullName.IUnknown] = WellKnownTypes.SystemIntPtr;

            if (context.Configuration.Generation.HRESULTIsError)
            {
                var hr = context.AllTypes[FullName.HRESULT];
                var hresult = hr.Clone(context);
                hresult.UnmanagedType = UnmanagedType.Error;
                context.MappedTypes[FullName.HRESULT] = hresult;
            }
        }

        protected virtual void GenerateTypes(BuilderContext context)
        {
            ArgumentNullException.ThrowIfNull(context);
            ArgumentNullException.ThrowIfNull(context.MetadataReader);
            ArgumentNullException.ThrowIfNull(context.Configuration);
            ArgumentNullException.ThrowIfNull(context.Configuration.Generation);
            ArgumentNullException.ThrowIfNull(context.Configuration.OutputDirectoryPath);

            if (context.Configuration.DeleteOutputDirectory)
            {
                IOUtilities.DirectoryDelete(context.Configuration.OutputDirectoryPath, true);
            }

            if (context.Configuration.RemoveNonGeneratedFiles && IOUtilities.PathIsDirectory(context.Configuration.OutputDirectoryPath))
            {
                context.ExistingFiles.AddRange(Directory.EnumerateFileSystemEntries(context.Configuration.OutputDirectoryPath, "*.cs", SearchOption.AllDirectories));
            }

            AddMappedTypes(context);
            foreach (var type in context.TypesToBuild.OrderBy(t => t.FullName))
            {
                var finalType = type;
                context.LogVerbose(finalType);
                if (context.MappedTypes.TryGetValue(type.FullName, out var mappedType))
                {
                    context.LogVerbose(finalType + " => " + mappedType);
                    finalType = mappedType;
                }

                if (!finalType.IsGenerated)
                    continue;

                finalType.Generate(context);
            }

            if (context.Configuration.RemoveNonGeneratedFiles)
            {
                foreach (var filePath in context.ExistingFiles)
                {
                    IOUtilities.FileDelete(filePath);
                }
                IOUtilities.DirectoryDeleteEmptySubDirectories(context.Configuration.OutputDirectoryPath);
            }

            var un = context.Configuration.GetGeneration();
            if (un != null)
            {
                // build pseudo-types
                if (un.ConstantsFileName != null)
                {
                    var fields = context.ConstantsTypes.SelectMany(t => t.Fields).ToHashSet();
                    var constantsType = context.CreateBuilderType(new FullName(un.Namespace!, un.ConstantsFileName));
                    constantsType.Fields.AddRange(fields);

                    if (constantsType.IsGenerated)
                    {
                        constantsType.Generate(context);
                    }
                }

                if (un.FunctionsFileName != null)
                {
                    var functions = context.FunctionsTypes.SelectMany(t => t.Methods).ToHashSet();
                    var functionsType = context.CreateBuilderType(new FullName(un.Namespace!, un.FunctionsFileName));
                    functionsType.Methods.AddRange(functions);

                    if (functionsType.IsGenerated)
                    {
                        functionsType.Generate(context);
                    }
                }
            }
        }
    }
}
