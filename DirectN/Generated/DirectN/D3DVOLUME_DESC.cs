#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/direct3d9/d3dvolume-desc
[StructLayout(LayoutKind.Sequential)]
public partial struct D3DVOLUME_DESC
{
    public D3DFORMAT Format;
    public D3DRESOURCETYPE Type;
    public uint Usage;
    public D3DPOOL Pool;
    public uint Width;
    public uint Height;
    public uint Depth;
}
