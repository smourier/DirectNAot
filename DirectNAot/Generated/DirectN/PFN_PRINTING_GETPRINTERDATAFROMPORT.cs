namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate bool PFN_PRINTING_GETPRINTERDATAFROMPORT(HANDLE param0, uint param1, PWSTR param2, PWSTR param3, uint param4, PWSTR param5, uint param6, nint param7);
