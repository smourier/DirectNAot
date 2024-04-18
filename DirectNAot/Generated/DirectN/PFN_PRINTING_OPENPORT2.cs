namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate bool PFN_PRINTING_OPENPORT2(HANDLE param0, PWSTR param1, nint param2);
