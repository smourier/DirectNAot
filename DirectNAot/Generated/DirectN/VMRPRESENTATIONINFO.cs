namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/ns-strmif-vmrpresentationinfo
[StructLayout(LayoutKind.Sequential)]
public partial struct VMRPRESENTATIONINFO
{
    public uint dwFlags;
    public nint lpSurf;
    public long rtStart;
    public long rtEnd;
    public FoundationSIZE szAspectRatio;
    public FoundationRECT rcSrc;
    public FoundationRECT rcDst;
    public uint dwTypeSpecificFlags;
    public uint dwInterlaceFlags;
}
