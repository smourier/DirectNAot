namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate void PAudioStateMonitorCallback(nint /*  IAudioStateMonitor */ audioStateMonitor, nint/* nint */ context);
