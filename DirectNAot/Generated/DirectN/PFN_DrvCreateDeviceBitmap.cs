namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate HBITMAP PFN_DrvCreateDeviceBitmap(DHPDEV param0, FoundationSIZE param1, uint param2);
