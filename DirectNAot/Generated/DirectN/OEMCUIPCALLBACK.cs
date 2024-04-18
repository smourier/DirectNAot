namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate int OEMCUIPCALLBACK(nint param0, nint param1);
