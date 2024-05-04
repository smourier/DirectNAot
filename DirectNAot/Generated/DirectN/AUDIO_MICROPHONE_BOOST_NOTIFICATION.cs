#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/audioengineextensionapo/ns-audioengineextensionapo-audio_microphone_boost_notification
[StructLayout(LayoutKind.Sequential)]
public partial struct AUDIO_MICROPHONE_BOOST_NOTIFICATION
{
    public nint endpoint;
    public Guid eventContext;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool microphoneBoostEnabled;
    public float levelInDb;
    public float levelMinInDb;
    public float levelMaxInDb;
    public float levelStepInDb;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool muteSupported;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool mute;
}
