#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_dxil_library_desc
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_DXIL_LIBRARY_DESC
{
    public D3D12_SHADER_BYTECODE DXILLibrary;
    public uint NumExports;
    public nint pExports;
}
