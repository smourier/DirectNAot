#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/ns-d3d11-d3d11_buffer_desc
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D11_BUFFER_DESC
{
    public uint ByteWidth;
    public D3D11_USAGE Usage;
    public uint BindFlags;
    public uint CPUAccessFlags;
    public uint MiscFlags;
    public uint StructureByteStride;
}
