#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSAUDIO_POSITION
{
    public ulong PlayOffset;
    public ulong WriteOffset;
}
