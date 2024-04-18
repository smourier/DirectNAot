namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate uint LPFNDEVMODE(HWND param0, HMODULE param1, nint param2, PSTR param3, PSTR param4, nint param5, PSTR param6, uint param7);
