#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_render_pass_render_target_desc
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_RENDER_PASS_RENDER_TARGET_DESC
{
    public D3D12_CPU_DESCRIPTOR_HANDLE cpuDescriptor;
    public D3D12_RENDER_PASS_BEGINNING_ACCESS BeginningAccess;
    public D3D12_RENDER_PASS_ENDING_ACCESS EndingAccess;
}
