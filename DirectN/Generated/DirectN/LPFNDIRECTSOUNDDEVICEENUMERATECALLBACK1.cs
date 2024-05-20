#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
[return: MarshalAs(UnmanagedType.U4)]
public delegate bool LPFNDIRECTSOUNDDEVICEENUMERATECALLBACK1(nint param0, nint param1);
