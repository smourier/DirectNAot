namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mpegtype/ns-mpegtype-am_mpegsystemtype
[StructLayout(LayoutKind.Sequential)]
public partial struct AM_MPEGSYSTEMTYPE
{
    public uint dwBitRate;
    public uint cStreams;
    public InlineArrayAM_MPEGSTREAMTYPE1 Streams; // variable-length array placeholder
}
