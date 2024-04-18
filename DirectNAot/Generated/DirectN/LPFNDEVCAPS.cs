namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate uint LPFNDEVCAPS(PSTR param0, PSTR param1, uint param2, PSTR param3, nint param4);
