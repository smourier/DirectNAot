#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSAUDIO_MIXLEVEL
{
    public BOOL Mute;
    public int Level;
}
