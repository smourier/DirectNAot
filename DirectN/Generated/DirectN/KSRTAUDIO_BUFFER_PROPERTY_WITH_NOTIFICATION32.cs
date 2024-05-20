#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSRTAUDIO_BUFFER_PROPERTY_WITH_NOTIFICATION32
{
    public KSIDENTIFIER Property;
    public uint BaseAddress;
    public uint RequestedBufferSize;
    public uint NotificationCount;
}
