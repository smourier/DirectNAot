#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/direct3d9/d3dsurface-desc
[StructLayout(LayoutKind.Sequential)]
public partial struct D3DSURFACE_DESC
{
    public D3DFORMAT Format;
    public D3DRESOURCETYPE Type;
    public uint Usage;
    public D3DPOOL Pool;
    public D3DMULTISAMPLE_TYPE MultiSampleType;
    public uint MultiSampleQuality;
    public uint Width;
    public uint Height;
}
