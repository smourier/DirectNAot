namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/ns-d3d11-d3d11_texture3d_desc
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D11_TEXTURE3D_DESC
{
    public uint Width;
    public uint Height;
    public uint Depth;
    public uint MipLevels;
    public DXGI_FORMAT Format;
    public D3D11_USAGE Usage;
    public uint BindFlags;
    public uint CPUAccessFlags;
    public uint MiscFlags;
}
