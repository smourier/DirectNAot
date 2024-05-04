#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/ns-d3d11-d3d11_mapped_subresource
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D11_MAPPED_SUBRESOURCE
{
    public nint pData;
    public uint RowPitch;
    public uint DepthPitch;
}
