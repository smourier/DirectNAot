namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate bool PFN_PRINTING_WRITEPORT2(HANDLE param0, nint /* byte array */ param1, uint param2, nint param3);
