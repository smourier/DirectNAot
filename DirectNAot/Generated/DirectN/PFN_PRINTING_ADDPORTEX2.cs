namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate bool PFN_PRINTING_ADDPORTEX2(HANDLE param0, PWSTR param1, uint param2, nint /* byte array */ param3, PWSTR param4);
