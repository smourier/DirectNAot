#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_memcpy_dest
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_MEMCPY_DEST
{
    public nint pData;
    public nuint RowPitch;
    public nuint SlicePitch;
}
