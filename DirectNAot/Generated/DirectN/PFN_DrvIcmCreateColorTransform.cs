namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate HANDLE PFN_DrvIcmCreateColorTransform(DHPDEV param0, nint param1, nint param2, uint param3, nint param4, uint param5, nint param6, uint param7, uint param8);
