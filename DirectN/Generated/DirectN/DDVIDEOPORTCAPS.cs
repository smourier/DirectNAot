#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dvp/ns-dvp-ddvideoportcaps
public partial struct DDVIDEOPORTCAPS
{
    public uint dwSize;
    public uint dwFlags;
    public uint dwMaxWidth;
    public uint dwMaxVBIWidth;
    public uint dwMaxHeight;
    public uint dwVideoPortID;
    public uint dwCaps;
    public uint dwFX;
    public uint dwNumAutoFlipSurfaces;
    public uint dwAlignVideoPortBoundary;
    public uint dwAlignVideoPortPrescaleWidth;
    public uint dwAlignVideoPortCropBoundary;
    public uint dwAlignVideoPortCropWidth;
    public uint dwPreshrinkXStep;
    public uint dwPreshrinkYStep;
    public uint dwNumVBIAutoFlipSurfaces;
    public uint dwNumPreferredAutoflip;
    public ushort wNumFilterTapsX;
    public ushort wNumFilterTapsY;
}
