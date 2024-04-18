namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate bool PFN_PRINTING_XCVOPENPORT2(HANDLE param0, PWSTR param1, uint param2, nint param3);
