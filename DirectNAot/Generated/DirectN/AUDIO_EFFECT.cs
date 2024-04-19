namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/audioclient/ns-audioclient-audio_effect
[StructLayout(LayoutKind.Sequential)]
public partial struct AUDIO_EFFECT
{
    public Guid id;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool canSetState;
    public AUDIO_EFFECT_STATE state;
}
