namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate bool PFN_PRINTING_XCVOPENPORT(PWSTR param0, uint param1, nint param2);
