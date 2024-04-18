namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate void PDX_IRQCALLBACK(nint pIrqData);
