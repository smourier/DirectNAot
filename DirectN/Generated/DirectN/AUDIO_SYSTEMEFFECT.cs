#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/audioengineextensionapo/ns-audioengineextensionapo-audio_systemeffect
[StructLayout(LayoutKind.Sequential)]
public partial struct AUDIO_SYSTEMEFFECT
{
    public Guid id;
    public BOOL canSetState;
    public AUDIO_SYSTEMEFFECT_STATE state;
}
