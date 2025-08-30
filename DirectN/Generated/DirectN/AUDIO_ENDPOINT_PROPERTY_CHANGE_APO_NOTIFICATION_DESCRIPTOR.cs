#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/audioengineextensionapo/ns-audioengineextensionapo-audio_endpoint_property_change_apo_notification_descriptor
public partial struct AUDIO_ENDPOINT_PROPERTY_CHANGE_APO_NOTIFICATION_DESCRIPTOR : IValueGet<nint>
{
    public nint device;
    
    readonly nint IValueGet<nint>.GetValue() => device;
    readonly object? IValueGet.GetValue() => device;
}
