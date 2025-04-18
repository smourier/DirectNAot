#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/audioengineextensionapo/ns-audioengineextensionapo-audio_microphone_boost_notification
public partial struct AUDIO_MICROPHONE_BOOST_NOTIFICATION
{
    public nint endpoint;
    public Guid eventContext;
    public BOOL microphoneBoostEnabled;
    public float levelInDb;
    public float levelMinInDb;
    public float levelMaxInDb;
    public float levelStepInDb;
    public BOOL muteSupported;
    public BOOL mute;
}
