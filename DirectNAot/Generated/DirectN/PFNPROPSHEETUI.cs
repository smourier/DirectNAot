namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate int PFNPROPSHEETUI(nint pPSUIInfo, LPARAM lParam);
