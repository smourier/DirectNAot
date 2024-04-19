namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xaudio2/ns-xaudio2-xaudio2_send_descriptor
[StructLayout(LayoutKind.Sequential)]
public partial struct XAUDIO2_SEND_DESCRIPTOR
{
    public uint Flags;
    public nint pOutputVoice;
}
