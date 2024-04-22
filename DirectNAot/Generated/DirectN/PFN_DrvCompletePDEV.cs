namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate void PFN_DrvCompletePDEV(DHPDEV param0, HDEV param1);
