#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11sdklayers/ns-d3d11sdklayers-d3d11_info_queue_filter
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D11_INFO_QUEUE_FILTER
{
    public D3D11_INFO_QUEUE_FILTER_DESC AllowList;
    public D3D11_INFO_QUEUE_FILTER_DESC DenyList;
}
