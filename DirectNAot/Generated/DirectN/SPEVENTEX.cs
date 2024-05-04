#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct SPEVENTEX
{
    public int _bitfield;
    public uint ulStreamNum;
    public ulong ullAudioStreamOffset;
    public WPARAM wParam;
    public LPARAM lParam;
    public ulong ullAudioTimeOffset;
}
