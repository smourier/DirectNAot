using System.Reflection;
using System.Runtime.InteropServices;

#if DEBUG
[assembly: AssemblyConfiguration("DEBUG")]
#else
[assembly: AssemblyConfiguration("RELEASE")]
#endif

[assembly: AssemblyTitle("DirectNAot.InteropBuilder")]
[assembly: AssemblyProduct("DirectNAot")]
[assembly: AssemblyCopyright("Copyright (C) 2017-2024 Simon Mourier. All rights reserved.")]
[assembly: AssemblyDescription("Interop Code Builder for DirectN AOT")]
[assembly: AssemblyCompany("Simon Mourier")]
[assembly: AssemblyCulture("")]
[assembly: Guid("46787061-4118-4706-8e6a-8cfec8501fa4")]
