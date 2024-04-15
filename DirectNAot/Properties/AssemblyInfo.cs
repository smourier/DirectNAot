using System.Reflection;

#if DEBUG
[assembly: AssemblyConfiguration("DEBUG")]
#else
[assembly: AssemblyConfiguration("RELEASE")]
#endif

[assembly: AssemblyTitle("DirectNAot")]
[assembly: AssemblyProduct("DirectN")]
[assembly: AssemblyCopyright("Copyright (C) 2017-2024 Simon Mourier. All rights reserved.")]
[assembly: AssemblyCulture("")]
[assembly: AssemblyDescription("Interop Code for .NET Core: DXGI, WIC, DirectX 9 to 12, Direct2D, Direct Write, Direct Composition, Media Foundation, WASAPI, CodecAPI, GDI, Spatial Audio, DVD, Windows Media Player, UWP DXInterop, WinUI3, etc.")]
[assembly: AssemblyCompany("Simon Mourier")]
[assembly: Guid("dfc45e33-cf51-49e3-bc3f-a4dfd2bee1ad")]
[assembly: DisableRuntimeMarshalling]
