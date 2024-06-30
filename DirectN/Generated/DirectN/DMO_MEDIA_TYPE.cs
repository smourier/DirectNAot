#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mediaobj/ns-mediaobj-dmo_media_type
public partial struct DMO_MEDIA_TYPE
{
    public Guid majortype;
    public Guid subtype;
    public BOOL bFixedSizeSamples;
    public BOOL bTemporalCompression;
    public uint lSampleSize;
    public Guid formattype;
    public nint pUnk;
    public uint cbFormat;
    public nint pbFormat;
}
