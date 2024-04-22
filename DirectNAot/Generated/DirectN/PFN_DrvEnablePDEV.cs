namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate DHPDEV PFN_DrvEnablePDEV(nint param0, PWSTR param1, uint param2, nint param3, uint param4, nint param5, uint param6, nint param7, HDEV param8, PWSTR param9, HANDLE param10);
