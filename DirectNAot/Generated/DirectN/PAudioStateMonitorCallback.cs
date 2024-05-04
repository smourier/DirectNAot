#nullable enable
namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate void PAudioStateMonitorCallback(nint /* IAudioStateMonitor */ audioStateMonitor, nint /* optional void* */ context);
