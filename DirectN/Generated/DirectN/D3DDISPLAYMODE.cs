#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/direct3d9/d3ddisplaymode
public partial struct D3DDISPLAYMODE
{
    public uint Width;
    public uint Height;
    public uint RefreshRate;
    public D3DFORMAT Format;
}
