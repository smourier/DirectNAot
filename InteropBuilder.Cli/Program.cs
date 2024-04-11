using System;
using System.IO;
using System.Linq;
using System.Reflection;
using Win32InteropBuilder;

namespace InteropBuilder.Cli
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("InteropBuilder - Copyright (C) 2017-" + DateTime.Now.Year + " Simon Mourier. All rights reserved.");
            Console.WriteLine();
            var builderPath = CommandLine.Current.GetNullifiedArgument("builder");
            if (CommandLine.Current.HelpRequested || builderPath == null)
            {
                Help();
                return;
            }

            var asm = Assembly.LoadFrom(builderPath);
            var type = asm.GetTypes().FirstOrDefault(t => typeof(Builder).IsAssignableFrom(t));
            if (type == null)
            {
                Console.WriteLine($"Cannot find any builder type in assembly {asm.FullName}.");
                return;
            }
            Console.WriteLine($"Running {type.FullName} builder...");

            var builder = (Builder)Activator.CreateInstance(type)!;
            var winmd = Path.Combine(Win32Metadata.WinMdPath, "Windows.Win32.winmd");
            var context = builder.CreateBuilderContext(winmd);
            builder.Build(context);
        }

        static void Help()
        {
            Console.WriteLine(Assembly.GetEntryAssembly()!.GetName().Name!.ToUpperInvariant() + " <input builder assembly path> <output file path>");
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
