#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/direct3d9/d3dclipstatus9
public partial struct D3DCLIPSTATUS9
{
    public uint ClipUnion;
    public uint ClipIntersection;
}
