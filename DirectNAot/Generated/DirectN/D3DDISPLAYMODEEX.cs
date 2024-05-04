#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/direct3d9/d3ddisplaymodeex
[StructLayout(LayoutKind.Sequential)]
public partial struct D3DDISPLAYMODEEX
{
    public uint Size;
    public uint Width;
    public uint Height;
    public uint RefreshRate;
    public D3DFORMAT Format;
    public D3DSCANLINEORDERING ScanLineOrdering;
}
