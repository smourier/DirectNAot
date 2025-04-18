#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfapi/ns-mfapi-mt_arbitrary_header
public partial struct MT_ARBITRARY_HEADER
{
    public Guid majortype;
    public Guid subtype;
    public BOOL bFixedSizeSamples;
    public BOOL bTemporalCompression;
    public uint lSampleSize;
    public Guid formattype;
}
