#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/ns-strmif-vmrpresentationinfo
public partial struct VMRPRESENTATIONINFO
{
    public uint dwFlags;
    public nint lpSurf;
    public long rtStart;
    public long rtEnd;
    public SIZE szAspectRatio;
    public RECT rcSrc;
    public RECT rcDst;
    public uint dwTypeSpecificFlags;
    public uint dwInterlaceFlags;
}
