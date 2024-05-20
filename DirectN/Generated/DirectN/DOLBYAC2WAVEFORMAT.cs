#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DOLBYAC2WAVEFORMAT
{
    public WAVEFORMATEX wfx;
    public ushort nAuxBitsCode;
}
