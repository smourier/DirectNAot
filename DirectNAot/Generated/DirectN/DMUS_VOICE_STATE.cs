namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dmusics/ns-dmusics-dmus_voice_state
[StructLayout(LayoutKind.Sequential)]
public partial struct DMUS_VOICE_STATE
{
    [MarshalAs(UnmanagedType.U4)]
    public bool bExists;
    public ulong spPosition;
}
