#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate BOOL LPFNDIRECTSOUNDDEVICEENUMERATECALLBACK1(nint param0, nint param1);
