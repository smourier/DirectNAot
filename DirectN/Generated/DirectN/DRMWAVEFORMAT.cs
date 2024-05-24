#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct DRMWAVEFORMAT
{
    public WAVEFORMATEX wfx;
    public ushort wReserved;
    public uint ulContentId;
    public WAVEFORMATEX wfxSecure;
}
