namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/vmr9/ns-vmr9-vmr9videostreaminfo
[StructLayout(LayoutKind.Sequential)]
public partial struct VMR9VideoStreamInfo
{
    public nint pddsVideoSurface;
    public uint dwWidth;
    public uint dwHeight;
    public uint dwStrmID;
    public float fAlpha;
    public VMR9NormalizedRect rNormal;
    public long rtStart;
    public long rtEnd;
    public VMR9_SampleFormat SampleFormat;
}
