#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSRTAUDIO_NOTIFICATION_EVENT_PROPERTY32
{
    public KSIDENTIFIER Property;
    public uint NotificationEvent;
}
