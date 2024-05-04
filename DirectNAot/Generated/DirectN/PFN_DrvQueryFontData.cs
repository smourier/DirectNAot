#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate int PFN_DrvQueryFontData(DHPDEV param0, nint param1, uint param2, uint param3, nint param4, nint param5, uint param6);
