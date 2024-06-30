#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/ns-strmif-vmrvideostreaminfo
public partial struct VMRVIDEOSTREAMINFO
{
    public nint pddsVideoSurface;
    public uint dwWidth;
    public uint dwHeight;
    public uint dwStrmID;
    public float fAlpha;
    public DDCOLORKEY ddClrKey;
    public NORMALIZEDRECT rNormal;
}
