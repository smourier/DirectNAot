#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dmusics/ns-dmusics-dmus_voice_state
public partial struct DMUS_VOICE_STATE
{
    public BOOL bExists;
    public ulong spPosition;
}
