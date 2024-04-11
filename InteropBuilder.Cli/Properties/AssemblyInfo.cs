using System.Reflection;
using System.Runtime.InteropServices;

#if DEBUG
[assembly: AssemblyConfiguration("DEBUG")]
#else
[assembly: AssemblyConfiguration("RELEASE")]
#endif

[assembly: AssemblyTitle("InteropBuilder.Cli")]
[assembly: AssemblyProduct("Win32InteropBuilder")]
[assembly: AssemblyCopyright("Copyright (C) 2017-2024 Simon Mourier. All rights reserved.")]
[assembly: AssemblyDescription("Interop Code Builder for Win32 Client")]
[assembly: AssemblyCompany("Simon Mourier")]
[assembly: AssemblyCulture("")]
[assembly: Guid("9103ca93-0edc-4c4b-a932-c66343d83694")]
