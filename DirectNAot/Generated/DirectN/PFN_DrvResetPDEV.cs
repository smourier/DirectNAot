namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate bool PFN_DrvResetPDEV(DHPDEV dhpdevOld, DHPDEV dhpdevNew);
