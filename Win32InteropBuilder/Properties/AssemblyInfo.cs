using System.Reflection;
using System.Runtime.InteropServices;

#if DEBUG
[assembly: AssemblyConfiguration("DEBUG")]
#else
[assembly: AssemblyConfiguration("RELEASE")]
#endif

[assembly: AssemblyTitle("Win32InteropBuilder")]
[assembly: AssemblyProduct("Win32InteropBuilder")]
[assembly: AssemblyCopyright("Copyright (C) 2017-2024 Simon Mourier. All rights reserved.")]
[assembly: AssemblyDescription("Interop Code Builder for Win32")]
[assembly: AssemblyCompany("Simon Mourier")]
[assembly: AssemblyCulture("")]
[assembly: Guid("1132106f-d177-4715-a85f-90b226489ea1")]
