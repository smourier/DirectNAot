namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate bool PFN_PRINTING_ENUMPORTS2(HANDLE param0, PWSTR param1, uint param2, nint param3, uint param4, nint param5, nint param6);
