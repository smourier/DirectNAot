namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate int FONTENUMPROCW(nint /* in LOGFONTW */ param0, nint /* in TEXTMETRICW */ param1, uint param2, LPARAM param3);
