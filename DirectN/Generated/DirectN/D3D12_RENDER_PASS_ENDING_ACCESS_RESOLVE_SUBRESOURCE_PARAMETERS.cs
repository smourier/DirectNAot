#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_render_pass_ending_access_resolve_subresource_parameters
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_RENDER_PASS_ENDING_ACCESS_RESOLVE_SUBRESOURCE_PARAMETERS
{
    public uint SrcSubresource;
    public uint DstSubresource;
    public uint DstX;
    public uint DstY;
    public RECT SrcRect;
}
