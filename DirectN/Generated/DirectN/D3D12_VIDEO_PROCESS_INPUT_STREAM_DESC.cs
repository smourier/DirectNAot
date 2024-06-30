#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/ns-d3d12video-d3d12_video_process_input_stream_desc
public partial struct D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC
{
    public DXGI_FORMAT Format;
    public DXGI_COLOR_SPACE_TYPE ColorSpace;
    public DXGI_RATIONAL SourceAspectRatio;
    public DXGI_RATIONAL DestinationAspectRatio;
    public DXGI_RATIONAL FrameRate;
    public D3D12_VIDEO_SIZE_RANGE SourceSizeRange;
    public D3D12_VIDEO_SIZE_RANGE DestinationSizeRange;
    public BOOL EnableOrientation;
    public D3D12_VIDEO_PROCESS_FILTER_FLAGS FilterFlags;
    public D3D12_VIDEO_FRAME_STEREO_FORMAT StereoFormat;
    public D3D12_VIDEO_FIELD_TYPE FieldType;
    public D3D12_VIDEO_PROCESS_DEINTERLACE_FLAGS DeinterlaceMode;
    public BOOL EnableAlphaBlending;
    public D3D12_VIDEO_PROCESS_LUMA_KEY LumaKey;
    public uint NumPastFrames;
    public uint NumFutureFrames;
    public BOOL EnableAutoProcessing;
}
