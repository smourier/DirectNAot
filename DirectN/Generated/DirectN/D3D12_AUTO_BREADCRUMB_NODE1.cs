#nullable enable
namespace DirectN;

public partial struct D3D12_AUTO_BREADCRUMB_NODE1
{
    public PSTR pCommandListDebugNameA;
    public PWSTR pCommandListDebugNameW;
    public PSTR pCommandQueueDebugNameA;
    public PWSTR pCommandQueueDebugNameW;
    public nint pCommandList;
    public nint pCommandQueue;
    public uint BreadcrumbCount;
    public nint pLastBreadcrumbValue;
    public nint pCommandHistory;
    public nint pNext;
    public uint BreadcrumbContextsCount;
    public nint pBreadcrumbContexts;
}
