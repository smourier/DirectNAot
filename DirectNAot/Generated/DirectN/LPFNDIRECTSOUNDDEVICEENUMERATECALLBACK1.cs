#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate bool LPFNDIRECTSOUNDDEVICEENUMERATECALLBACK1(nint param0, nint param1);
