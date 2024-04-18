namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate uint PFN_PRINTING_SENDRECVBIDIDATAFROMPORT2(HANDLE param0, uint param1, PWSTR param2, nint /* in BIDI_REQUEST_CONTAINER */ param3, nint param4);
