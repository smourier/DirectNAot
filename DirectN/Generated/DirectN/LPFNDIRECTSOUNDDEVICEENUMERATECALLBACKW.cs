#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate BOOL LPFNDIRECTSOUNDDEVICEENUMERATECALLBACKW(nint param0, nint param1);
