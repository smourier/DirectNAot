#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate BOOL PFN_DrvStretchBlt(nint param0, nint param1, nint param2, nint param3, nint param4, nint param5, nint param6, nint param7, nint param8, nint param9, uint param10);
