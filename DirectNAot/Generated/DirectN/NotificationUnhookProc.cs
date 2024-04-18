namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate void NotificationUnhookProc(nuint token);
