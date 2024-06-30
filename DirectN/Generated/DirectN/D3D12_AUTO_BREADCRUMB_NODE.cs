#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_auto_breadcrumb_node
public partial struct D3D12_AUTO_BREADCRUMB_NODE
{
    public nint pCommandListDebugNameA;
    public PWSTR pCommandListDebugNameW;
    public nint pCommandQueueDebugNameA;
    public PWSTR pCommandQueueDebugNameW;
    public nint pCommandList;
    public nint pCommandQueue;
    public uint BreadcrumbCount;
    public nint pLastBreadcrumbValue;
    public nint pCommandHistory;
    public nint pNext;
}
