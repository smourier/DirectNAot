#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11_4/ns-d3d11_4-d3d11_feature_data_video_decoder_histogram
public partial struct D3D11_FEATURE_DATA_VIDEO_DECODER_HISTOGRAM
{
    public D3D11_VIDEO_DECODER_DESC DecoderDesc;
    public D3D11_VIDEO_DECODER_HISTOGRAM_COMPONENT_FLAGS Components;
    public uint BinCount;
    public uint CounterBitDepth;
}
