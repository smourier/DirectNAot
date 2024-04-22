namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate int PFN_DrvRenderHint(DHPDEV dhpdev, uint NotifyCode, nuint Length, nint /* optional void */ Data);
