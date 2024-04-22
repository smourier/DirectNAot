namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate void PFN_DrvGetTrueTypeFile(nuint param0, nint param1);
