namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate bool PFN_DrvQuerySpoolType(DHPDEV dhpdev, PWSTR pwchType);
