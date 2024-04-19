namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSRTAUDIO_NOTIFICATION_EVENT_PROPERTY
{
    public KSIDENTIFIER Property;
    public HANDLE NotificationEvent;
}
