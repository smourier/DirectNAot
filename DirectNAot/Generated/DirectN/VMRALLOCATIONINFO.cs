namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/ns-strmif-vmrallocationinfo
[StructLayout(LayoutKind.Sequential)]
public partial struct VMRALLOCATIONINFO
{
    public uint dwFlags;
    public nint lpHdr;
    public nint lpPixFmt;
    public FoundationSIZE szAspectRatio;
    public uint dwMinBuffers;
    public uint dwMaxBuffers;
    public uint dwInterlaceFlags;
    public FoundationSIZE szNativeSize;
}
