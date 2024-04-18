namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate bool PFN_PRINTING_READPORT2(HANDLE param0, nint param1, uint param2, nint param3);
