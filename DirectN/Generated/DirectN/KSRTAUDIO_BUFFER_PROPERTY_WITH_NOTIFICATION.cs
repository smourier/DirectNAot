#nullable enable
namespace DirectN;

public partial struct KSRTAUDIO_BUFFER_PROPERTY_WITH_NOTIFICATION
{
    public KSIDENTIFIER Property;
    public nint BaseAddress;
    public uint RequestedBufferSize;
    public uint NotificationCount;
}
