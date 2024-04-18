namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate bool PFN_PRINTING_ENUMPORTS(PWSTR param0, uint param1, nint param2, uint param3, nint param4, nint param5);
