#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12sdklayers/ns-d3d12sdklayers-d3d12_info_queue_filter
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_INFO_QUEUE_FILTER
{
    public D3D12_INFO_QUEUE_FILTER_DESC AllowList;
    public D3D12_INFO_QUEUE_FILTER_DESC DenyList;
}
