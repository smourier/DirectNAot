#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSAUDIO_MIXLEVEL
{
    [MarshalAs(UnmanagedType.U4)]
    public bool Mute;
    public int Level;
}
