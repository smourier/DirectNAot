#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mpegtype/ns-mpegtype-am_mpegsystemtype
public partial struct AM_MPEGSYSTEMTYPE
{
    public uint dwBitRate;
    public uint cStreams;
    public InlineArrayAM_MPEGSTREAMTYPE_1 Streams; // variable-length array placeholder
}
