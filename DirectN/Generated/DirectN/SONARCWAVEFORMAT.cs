#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct SONARCWAVEFORMAT
{
    public WAVEFORMATEX wfx;
    public ushort wCompType;
}
