namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate IFIMETRICS PFN_DrvQueryFont(DHPDEV param0, nuint param1, uint param2, nint param3);
