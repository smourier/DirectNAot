namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate bool PFN_DrvIcmCheckBitmapBits(DHPDEV param0, HANDLE param1, nint param2, nint param3);
