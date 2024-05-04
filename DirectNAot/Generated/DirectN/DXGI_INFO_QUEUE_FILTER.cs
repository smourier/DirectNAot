#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxgidebug/ns-dxgidebug-dxgi_info_queue_filter
[StructLayout(LayoutKind.Sequential)]
public partial struct DXGI_INFO_QUEUE_FILTER
{
    public DXGI_INFO_QUEUE_FILTER_DESC AllowList;
    public DXGI_INFO_QUEUE_FILTER_DESC DenyList;
}
