namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate bool PFN_PRINTING_CONFIGUREPORT2(HANDLE param0, PWSTR param1, HWND param2, PWSTR param3);
