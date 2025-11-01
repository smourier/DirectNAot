#nullable enable
namespace DirectN;

public partial struct D3D12_VIDEO_ENCODER_INPUT_MAP_SESSION_INFO
{
    public D3D12_VIDEO_ENCODER_CODEC Codec;
    public D3D12_VIDEO_ENCODER_PROFILE_DESC Profile;
    public D3D12_VIDEO_ENCODER_LEVEL_SETTING Level;
    public DXGI_FORMAT InputFormat;
    public D3D12_VIDEO_ENCODER_PICTURE_RESOLUTION_DESC InputResolution;
    public D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION CodecConfiguration;
    public D3D12_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE SubregionFrameEncoding;
    public D3D12_VIDEO_ENCODER_PICTURE_CONTROL_SUBREGIONS_LAYOUT_DATA SubregionFrameEncodingData;
}
