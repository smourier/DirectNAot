#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate bool LPFNDIRECTSOUNDDEVICEENUMERATECALLBACKA(nint param0, nint param1);
