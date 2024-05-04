#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_AUTO_BREADCRUMB_NODE1
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
    public uint BreadcrumbContextsCount;
    public nint pBreadcrumbContexts;
}
