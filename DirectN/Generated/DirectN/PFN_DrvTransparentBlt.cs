#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate BOOL PFN_DrvTransparentBlt(nint param0, nint param1, nint param2, nint param3, nint param4, nint param5, uint param6, uint param7);
