namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate bool LPFNDIRECTSOUNDDEVICEENUMERATECALLBACKW(nint param0, nint param1);
