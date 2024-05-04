#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_dispatch_arguments
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_DISPATCH_ARGUMENTS
{
    public uint ThreadGroupCountX;
    public uint ThreadGroupCountY;
    public uint ThreadGroupCountZ;
}
