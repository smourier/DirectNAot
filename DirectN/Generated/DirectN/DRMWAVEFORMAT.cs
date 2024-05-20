#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DRMWAVEFORMAT
{
    public WAVEFORMATEX wfx;
    public ushort wReserved;
    public uint ulContentId;
    public WAVEFORMATEX wfxSecure;
}
