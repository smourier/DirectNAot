namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate nuint PFN_DrvSaveScreenBits(nint param0, uint param1, nuint param2, nint param3);
