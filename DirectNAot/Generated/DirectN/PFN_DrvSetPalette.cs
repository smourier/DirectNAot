namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate bool PFN_DrvSetPalette(DHPDEV param0, nint param1, uint param2, uint param3, uint param4);
