#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/ns-d3d11-d3d11_buffer_uav
public partial struct D3D11_BUFFER_UAV
{
    public uint FirstElement;
    public uint NumElements;
    public uint Flags;
}
