namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_FEATURE_DATA_VIDEO_DECODE_FORMAT_COUNT
{
    public uint NodeIndex;
    public D3D12_VIDEO_DECODE_CONFIGURATION Configuration;
    public uint FormatCount;
}
