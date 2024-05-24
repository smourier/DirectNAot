#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct DOLBYAC2WAVEFORMAT
{
    public WAVEFORMATEX wfx;
    public ushort nAuxBitsCode;
}
