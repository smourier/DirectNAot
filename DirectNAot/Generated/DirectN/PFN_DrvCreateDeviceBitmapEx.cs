namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate HBITMAP PFN_DrvCreateDeviceBitmapEx(DHPDEV param0, SIZE param1, uint param2, uint param3, DHSURF param4, uint param5, uint param6, nint param7);
