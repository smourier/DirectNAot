#nullable enable
namespace DirectN;

public partial struct KSDS3D_HRTF_INIT_MSG
{
    public uint Size;
    public KSDS3D_HRTF_FILTER_QUALITY Quality;
    public float SampleRate;
    public uint MaxFilterSize;
    public uint FilterTransientMuteLength;
    public uint FilterOverlapBufferLength;
    public uint OutputOverlapBufferLength;
    public uint Reserved;
}
