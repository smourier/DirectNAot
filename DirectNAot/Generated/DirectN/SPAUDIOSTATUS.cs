#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct SPAUDIOSTATUS
{
    public int cbFreeBuffSpace;
    public uint cbNonBlockingIO;
    public SPAUDIOSTATE State;
    public ulong CurSeekPos;
    public ulong CurDevicePos;
    public uint dwAudioLevel;
    public uint dwReserved2;
}
