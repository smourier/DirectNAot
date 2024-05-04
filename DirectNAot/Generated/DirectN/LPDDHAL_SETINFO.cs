#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate bool LPDDHAL_SETINFO(nint lpDDHalInfo, [MarshalAs(UnmanagedType.U4)] bool reset);
