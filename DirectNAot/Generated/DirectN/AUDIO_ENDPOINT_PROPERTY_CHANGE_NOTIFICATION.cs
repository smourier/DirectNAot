#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/audioengineextensionapo/ns-audioengineextensionapo-audio_endpoint_property_change_notification
[StructLayout(LayoutKind.Sequential)]
public partial struct AUDIO_ENDPOINT_PROPERTY_CHANGE_NOTIFICATION
{
    public nint endpoint;
    public nint propertyStore;
    public PROPERTYKEY propertyKey;
}
