namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MAP
{
    public uint SegmentsMapByteSize;
    public nint pSegmentsMap;
}
