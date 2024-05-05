#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
[return: MarshalAs(UnmanagedType.U4)]
public delegate bool LPDDHAL_SETINFO(nint lpDDHalInfo, [MarshalAs(UnmanagedType.U4)] bool reset);
