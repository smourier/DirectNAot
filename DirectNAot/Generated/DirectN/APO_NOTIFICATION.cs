#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/audioengineextensionapo/ns-audioengineextensionapo-apo_notification
[StructLayout(LayoutKind.Sequential)]
public partial struct APO_NOTIFICATION
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public AUDIO_ENDPOINT_VOLUME_CHANGE_NOTIFICATION audioEndpointVolumeChange;
        
        [FieldOffset(0)]
        public AUDIO_ENDPOINT_PROPERTY_CHANGE_NOTIFICATION audioEndpointPropertyChange;
        
        [FieldOffset(0)]
        public AUDIO_SYSTEMEFFECTS_PROPERTY_CHANGE_NOTIFICATION audioSystemEffectsPropertyChange;
        
        [FieldOffset(0)]
        public AUDIO_ENDPOINT_VOLUME_CHANGE_NOTIFICATION2 audioEndpointVolumeChange2;
        
        [FieldOffset(0)]
        public DEVICE_ORIENTATION_TYPE deviceOrientation;
        
        [FieldOffset(0)]
        public AUDIO_MICROPHONE_BOOST_NOTIFICATION audioMicrophoneBoostChange;
    }
    
    public APO_NOTIFICATION_TYPE type;
    public _Anonymous_e__Union Anonymous;
}
