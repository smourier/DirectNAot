﻿using System;
using System.IO;
using System.Reflection;
using Win32InteropBuilder.Utilities;

namespace DirectN.InteropBuilder.Cli
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("DirectN Builder - Copyright (C) 2017-" + DateTime.Now.Year + " Simon Mourier. All rights reserved.");
            Console.WriteLine();
            var configurationPath = CommandLine.Current.GetNullifiedArgument(0, "DirectN.json");
            if (CommandLine.Current.HelpRequested || configurationPath == null)
            {
                Help();
                return;
            }

            var winMdPath = Path.Combine(Win32Metadata.WinMdPath, "Windows.Win32.winmd");
            Win32InteropBuilder.Builder.Run(configurationPath, winMdPath);
        }

        static void Help()
        {
            Console.WriteLine(Assembly.GetEntryAssembly()!.GetName().Name!.ToUpperInvariant() + " [DirectN.json] <outputDirectoryPath>");
            Console.WriteLine();
            Console.WriteLine("Description:");
            Console.WriteLine("    This tool is used to generate DirectN AOT-friendly interop .cs files from Microsoft.Windows.SDK.Win32Metadata.");
            Console.WriteLine();
            Console.WriteLine("Examples:");
            Console.WriteLine();
            Console.WriteLine("    " + Assembly.GetEntryAssembly()!.GetName().Name!.ToUpperInvariant() + @" c:\myPath\DirectN.json");
            Console.WriteLine();
        }
    }
}
