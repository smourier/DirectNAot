namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate uint PFN_PRINTING_XCVDATAPORT2(HANDLE param0, PWSTR param1, nint /* byte array */ param2, uint param3, nint param4, uint param5, nint param6);
