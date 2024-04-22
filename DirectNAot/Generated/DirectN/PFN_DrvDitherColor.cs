namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate uint PFN_DrvDitherColor(DHPDEV param0, uint param1, uint param2, nint param3);
