namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate int FONTENUMPROCA(nint /* in LOGFONTA */ param0, nint /* in TEXTMETRICA */ param1, uint param2, LPARAM param3);
