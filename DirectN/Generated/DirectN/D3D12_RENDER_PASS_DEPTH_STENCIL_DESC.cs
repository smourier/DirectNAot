#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_render_pass_depth_stencil_desc
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_RENDER_PASS_DEPTH_STENCIL_DESC
{
    public D3D12_CPU_DESCRIPTOR_HANDLE cpuDescriptor;
    public D3D12_RENDER_PASS_BEGINNING_ACCESS DepthBeginningAccess;
    public D3D12_RENDER_PASS_BEGINNING_ACCESS StencilBeginningAccess;
    public D3D12_RENDER_PASS_ENDING_ACCESS DepthEndingAccess;
    public D3D12_RENDER_PASS_ENDING_ACCESS StencilEndingAccess;
}
