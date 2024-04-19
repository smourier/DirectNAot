namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/vmr9/ns-vmr9-vmr9presentationinfo
[StructLayout(LayoutKind.Sequential)]
public partial struct VMR9PresentationInfo
{
    public uint dwFlags;
    public nint lpSurf;
    public long rtStart;
    public long rtEnd;
    public FoundationSIZE szAspectRatio;
    public FoundationRECT rcSrc;
    public FoundationRECT rcDst;
    public uint dwReserved1;
    public uint dwReserved2;
}
