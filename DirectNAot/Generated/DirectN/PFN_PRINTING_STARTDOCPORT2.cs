namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate bool PFN_PRINTING_STARTDOCPORT2(HANDLE param0, PWSTR param1, uint param2, uint param3, nint /* byte array */ param4);
