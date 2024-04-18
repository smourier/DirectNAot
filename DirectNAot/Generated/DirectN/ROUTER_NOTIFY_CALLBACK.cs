namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate bool ROUTER_NOTIFY_CALLBACK(uint dwCommand, nint pContext, uint dwColor, nint /* in PRINTER_NOTIFY_INFO */ pNofityInfo, uint fdwFlags, nint pdwResult);
