#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate int PFN_DrvQueryFontFile(nuint param0, uint param1, uint param2, nint param3);
