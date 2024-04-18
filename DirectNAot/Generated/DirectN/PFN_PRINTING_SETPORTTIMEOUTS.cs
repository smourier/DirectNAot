namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate bool PFN_PRINTING_SETPORTTIMEOUTS(HANDLE param0, nint /* in COMMTIMEOUTS */ param1, uint param2);
