namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate uint PFN_DrvGetModes(HANDLE param0, uint param1, nint param2);
