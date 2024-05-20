#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate uint PFN_DrvFontManagement(nint param0, nint param1, uint param2, uint param3, nint param4, uint param5, nint param6);
