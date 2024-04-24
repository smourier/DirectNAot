namespace DirectN;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
public delegate void PFN_DXCORE_NOTIFICATION_CALLBACK(DXCoreNotificationType notificationType, nint /* nint */ @object, nint /* optional void* */ context);
