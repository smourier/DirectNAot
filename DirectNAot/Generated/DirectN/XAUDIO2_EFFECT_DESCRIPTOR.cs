namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xaudio2/ns-xaudio2-xaudio2_effect_descriptor
[StructLayout(LayoutKind.Sequential)]
public partial struct XAUDIO2_EFFECT_DESCRIPTOR
{
    public nint pEffect;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool InitialState;
    public uint OutputChannels;
}
