using System.Reflection;

#if DEBUG
[assembly: AssemblyConfiguration("DEBUG")]
#else
[assembly: AssemblyConfiguration("RELEASE")]
#endif

[assembly: AssemblyTitle("DirectNAot.Extensions")]
[assembly: AssemblyProduct("DirectN")]
[assembly: AssemblyCopyright("Copyright (C) 2017-2024 Simon Mourier. All rights reserved.")]
[assembly: AssemblyCulture("")]
[assembly: AssemblyDescription("Support code for DirectNAot")]
[assembly: AssemblyCompany("Simon Mourier")]
[assembly: Guid("952e737d-92da-4665-be06-f94f2fa90142")]
[assembly: DisableRuntimeMarshalling]
