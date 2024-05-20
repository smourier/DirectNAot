#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/direct3d9/d3ddisplaymodefilter
[StructLayout(LayoutKind.Sequential)]
public partial struct D3DDISPLAYMODEFILTER
{
    public uint Size;
    public D3DFORMAT Format;
    public D3DSCANLINEORDERING ScanLineOrdering;
}
