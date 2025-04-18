#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate BOOL LPFNDIRECTSOUNDDEVICEENUMERATECALLBACKA(nint param0, nint param1);
