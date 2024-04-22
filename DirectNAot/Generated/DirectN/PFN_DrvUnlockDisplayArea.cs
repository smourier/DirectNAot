namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate void PFN_DrvUnlockDisplayArea(DHPDEV param0, nint param1);
