namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate bool PFN_DrvEnableDriver(uint param0, uint param1, nint param2);
