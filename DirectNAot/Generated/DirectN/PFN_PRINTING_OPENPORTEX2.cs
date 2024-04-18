namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate bool PFN_PRINTING_OPENPORTEX2(HANDLE param0, HANDLE param1, PWSTR param2, PWSTR param3, nint param4, nint /* in MONITOR2 */ param5);
