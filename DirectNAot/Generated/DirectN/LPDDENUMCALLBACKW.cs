namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate bool LPDDENUMCALLBACKW(nint param0, PWSTR param1, PWSTR param2, nint param3);
