namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate uint PFN_PRINTING_POWEREVENT2(HANDLE param0, uint param1, nint/* nint */ param2);
