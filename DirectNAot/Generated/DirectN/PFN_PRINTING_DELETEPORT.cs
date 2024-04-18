namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate bool PFN_PRINTING_DELETEPORT(PWSTR param0, HWND param1, PWSTR param2);
