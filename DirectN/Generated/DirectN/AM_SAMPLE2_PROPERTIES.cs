#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/ns-strmif-am_sample2_properties
[StructLayout(LayoutKind.Sequential)]
public partial struct AM_SAMPLE2_PROPERTIES
{
    public uint cbData;
    public uint dwTypeSpecificFlags;
    public uint dwSampleFlags;
    public int lActual;
    public long tStart;
    public long tStop;
    public uint dwStreamId;
    public nint pMediaType;
    public nint pbBuffer;
    public int cbBuffer;
}
