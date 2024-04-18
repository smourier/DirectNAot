namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11_3/ns-d3d11_3-d3d11_texture2d_desc1
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D11_TEXTURE2D_DESC1
{
    public uint Width;
    public uint Height;
    public uint MipLevels;
    public uint ArraySize;
    public DXGI_FORMAT Format;
    public DXGI_SAMPLE_DESC SampleDesc;
    public D3D11_USAGE Usage;
    public uint BindFlags;
    public uint CPUAccessFlags;
    public uint MiscFlags;
    public D3D11_TEXTURE_LAYOUT TextureLayout;
}
