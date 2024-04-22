namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate uint PFN_DrvEscape(nint param0, uint param1, uint param2, nint param3, uint param4, nint param5);
