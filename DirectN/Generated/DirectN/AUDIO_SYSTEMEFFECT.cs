#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/audioengineextensionapo/ns-audioengineextensionapo-audio_systemeffect
public partial struct AUDIO_SYSTEMEFFECT
{
    public Guid id;
    public BOOL canSetState;
    public AUDIO_SYSTEMEFFECT_STATE state;
}
