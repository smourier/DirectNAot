namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate uint PFN_DrvDrawEscape(nint param0, uint param1, nint param2, nint param3, uint param4, nint param5);
