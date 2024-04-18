namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate bool PFN_PRINTING_OPENPORTEX(HANDLE param0, PWSTR param1, PWSTR param2, nint param3, nint /* in MONITOR2 */ param4);
