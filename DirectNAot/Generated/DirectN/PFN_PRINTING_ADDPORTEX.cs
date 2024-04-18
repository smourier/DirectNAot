namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate bool PFN_PRINTING_ADDPORTEX(PWSTR param0, uint param1, nint /* byte array */ param2, PWSTR param3);
