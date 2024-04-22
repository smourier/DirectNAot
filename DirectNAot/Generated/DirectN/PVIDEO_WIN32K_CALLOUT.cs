namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate void PVIDEO_WIN32K_CALLOUT(nint Params);
