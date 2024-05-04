#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10sdklayers/ns-d3d10sdklayers-d3d10_info_queue_filter
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D10_INFO_QUEUE_FILTER
{
    public D3D10_INFO_QUEUE_FILTER_DESC AllowList;
    public D3D10_INFO_QUEUE_FILTER_DESC DenyList;
}
