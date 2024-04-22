namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate void PFN_DrvQueryFontTree(DHPDEV param0, nuint param1, uint param2, uint param3, nint param4);
