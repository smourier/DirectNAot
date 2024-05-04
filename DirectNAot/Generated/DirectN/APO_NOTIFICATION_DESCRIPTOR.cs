#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/audioengineextensionapo/ns-audioengineextensionapo-apo_notification_descriptor
[StructLayout(LayoutKind.Sequential)]
public partial struct APO_NOTIFICATION_DESCRIPTOR
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public AUDIO_ENDPOINT_VOLUME_APO_NOTIFICATION_DESCRIPTOR audioEndpointVolume;
        
        [FieldOffset(0)]
        public AUDIO_ENDPOINT_PROPERTY_CHANGE_APO_NOTIFICATION_DESCRIPTOR audioEndpointPropertyChange;
        
        [FieldOffset(0)]
        public AUDIO_SYSTEMEFFECTS_PROPERTY_CHANGE_APO_NOTIFICATION_DESCRIPTOR audioSystemEffectsPropertyChange;
        
        [FieldOffset(0)]
        public AUDIO_MICROPHONE_BOOST_APO_NOTIFICATION_DESCRIPTOR audioMicrophoneBoost;
    }
    
    public APO_NOTIFICATION_TYPE type;
    public _Anonymous_e__Union Anonymous;
}
