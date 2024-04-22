namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate nuint PFN_DrvLoadFontFile(uint param0, nint param1, nint param2, nint param3, nint param4, uint param5, uint param6);
