#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
[return: MarshalAs(UnmanagedType.U4)]
public delegate bool PFN_DrvStrokePath(nint param0, nint param1, nint param2, nint param3, nint param4, nint param5, nint param6, uint param7);
