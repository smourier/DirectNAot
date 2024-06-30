#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/ns-d3d11-d3d11_video_processor_filter_range
public partial struct D3D11_VIDEO_PROCESSOR_FILTER_RANGE
{
    public int Minimum;
    public int Maximum;
    public int Default;
    public float Multiplier;
}
