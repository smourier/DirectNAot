using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices;
using System.Text.Json;
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
                //if (context.TypeDefinitions.TryGetValue(finalType.FullName, out var typeDef))
                //{
                //    var atts = typeDef.GetCustomAttributes();
                //    context.MetadataReader.SetDocumentation(atts, finalType);
                //    context.MetadataReader.SetSupportedOSPlatform(atts, finalType);
                //}

                Console.WriteLine(finalType);
                if (context.MappedTypes.TryGetValue(type.FullName, out var mappedType))
                {
                    Console.WriteLine(finalType + " => " + mappedType);
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
                if (un.ConstantsFileName != null)
                {
                    GenerateFile(context, un.ConstantsFileName, () =>
                    {
                        var fields = context.ConstantsTypes.SelectMany(t => t.Fields).ToHashSet();
                    });
                }

                if (un.FunctionsFileName != null)
                {
                    GenerateFile(context, un.FunctionsFileName, () =>
                    {
                        var functions = context.FunctionsTypes.SelectMany(t => t.Fields).ToHashSet();
                    });
                }
            }
        }

        protected virtual void GenerateFile(BuilderContext context, string fileName, Action generate)
        {
            ArgumentNullException.ThrowIfNull(context);
            ArgumentNullException.ThrowIfNull(context.Configuration);
            ArgumentNullException.ThrowIfNull(context.Configuration.OutputDirectoryPath);
            ArgumentNullException.ThrowIfNull(fileName);
            ArgumentNullException.ThrowIfNull(generate);

            var un = context.Configuration.GetGeneration();
            if (un == null)
                return;

            using var writer = new StringWriter();
            context.CurrentWriter = new IndentedTextWriter(writer);
            try
            {
                generate();
            }
            finally
            {
                context.CurrentWriter.Dispose();
                context.CurrentWriter = null;
            }

            var ns = un.Namespace!.Replace('.', Path.DirectorySeparatorChar);
            var text = writer.ToString();
            fileName += ".cs";
            var typePath = Path.Combine(context.Configuration.OutputDirectoryPath, ns, fileName);
            if (IOUtilities.PathIsFile(typePath))
            {
                var existingText = EncodingDetector.ReadAllText(typePath, context.Configuration.EncodingDetectorMode, out _);
                if (text == existingText)
                {
                    context.ExistingFiles.Remove(typePath);
                    return;
                }
            }

            IOUtilities.FileEnsureDirectory(typePath);
            File.WriteAllText(typePath, text, context.Configuration.FinalOutputEncoding);
            context.ExistingFiles.Remove(typePath);
        }

        protected virtual void GenerateFunctionsTypes(BuilderContext context)
        {
            ArgumentNullException.ThrowIfNull(context);
            if (context.FunctionsTypes.Count == 0)
                return;
        }

        protected virtual void GenerateConstantsTypes(BuilderContext context)
        {
            ArgumentNullException.ThrowIfNull(context);
            if (context.ConstantsTypes.Count == 0)
                return;
        }
    }
}
