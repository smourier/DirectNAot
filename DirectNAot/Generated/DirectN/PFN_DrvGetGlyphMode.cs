#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate uint PFN_DrvGetGlyphMode(DHPDEV dhpdev, nint pfo);
