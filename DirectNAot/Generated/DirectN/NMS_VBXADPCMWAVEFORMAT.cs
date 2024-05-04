#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct NMS_VBXADPCMWAVEFORMAT
{
    public WAVEFORMATEX wfx;
    public ushort wSamplesPerBlock;
}
