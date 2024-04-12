using System;
using System.IO;
using System.Reflection;
using System.Text.Json;
using Win32InteropBuilder;
using Win32InteropBuilder.Utilities;

namespace InteropBuilder.Cli
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("InteropBuilder - Copyright (C) 2017-" + DateTime.Now.Year + " Simon Mourier. All rights reserved.");
            Console.WriteLine();
            var configurationPath = CommandLine.Current.GetNullifiedArgument(0);
            if (CommandLine.Current.HelpRequested || configurationPath == null)
            {
                Help();
                return;
            }

            BuilderConfiguration? configuration;
            try
            {
                using var stream = File.OpenRead(configurationPath);
                configuration = JsonSerializer.Deserialize<BuilderConfiguration>(stream);
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

            configuration.BuilderTypeName ??= typeof(Builder).AssemblyQualifiedName!;
            Console.WriteLine("Builder type name: " + configuration.BuilderTypeName);

            var type = Type.GetType(configuration.BuilderTypeName, true);
            Console.WriteLine($"Running {type!.FullName} builder...");

            var builder = (Builder)Activator.CreateInstance(type)!;
            var winmd = Path.Combine(Win32Metadata.WinMdPath, "Windows.Win32.winmd");
            var context = builder.CreateBuilderContext(winmd);
            builder.Build(context);
        }

        static void Help()
        {
            Console.WriteLine(Assembly.GetEntryAssembly()!.GetName().Name!.ToUpperInvariant() + " <config.json>");
            Console.WriteLine();
            Console.WriteLine("Description:");
            Console.WriteLine("    This tool is used to generate .cs files from an interop builder assembly.");
            Console.WriteLine();
            Console.WriteLine("Options:");
            Console.WriteLine();
            Console.WriteLine("Examples:");
            Console.WriteLine();
            Console.WriteLine("    " + Assembly.GetEntryAssembly()!.GetName().Name!.ToUpperInvariant() + @" c:\mypath\myproject\myprojectInteropBuilder.dll");
            Console.WriteLine();
        }
    }
}
