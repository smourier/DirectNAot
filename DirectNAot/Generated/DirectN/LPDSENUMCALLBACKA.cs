namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate bool LPDSENUMCALLBACKA(nint param0, PSTR param1, PSTR param2, nint param3);
