using System;
using System.IO;
using System.Linq;
using System.Reflection;
using Win32InteropBuilder.Utilities;

namespace DirectN.InteropBuilder.Cli
{
    internal class Program
    {
        private const string _mainWinMdFileName = "Windows.Win32.winmd";
        private const string _winMdSearchPattern = "*.winmd";

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

            // the package splits its metadata, Direct3D 12 for instance lives in Microsoft.Direct3D.D3D12.winmd.
            var mainWinMdPath = Path.Combine(Win32Metadata.WinMdPath, _mainWinMdFileName);

            // a winmd shipped with this tool replaces the package one of the same name,
            // the package D3D12 one has no Agility SDK types, see https://github.com/smourier/d3d12-win32md.
            var localWinMdPaths = Directory.EnumerateFiles(AppContext.BaseDirectory, _winMdSearchPattern).ToArray();
            var satelliteWinMdPaths = Directory.EnumerateFiles(Win32Metadata.WinMdPath, _winMdSearchPattern)
                .Where(p => !p.EqualsIgnoreCase(mainWinMdPath))
                .Where(p => !localWinMdPaths.Any(l => Path.GetFileName(l).EqualsIgnoreCase(Path.GetFileName(p))))
                .Concat(localWinMdPaths)
                .Order(StringComparer.OrdinalIgnoreCase);

            Win32InteropBuilder.Builder.Run(configurationPath, [mainWinMdPath, .. satelliteWinMdPaths]);
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
