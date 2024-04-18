namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate uint PFN_PRINTING_NOTIFYUSEDPORTS2(HANDLE param0, uint param1, PWSTR param2);
