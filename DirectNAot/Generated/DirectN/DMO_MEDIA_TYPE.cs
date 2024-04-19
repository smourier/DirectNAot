namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mediaobj/ns-mediaobj-dmo_media_type
[StructLayout(LayoutKind.Sequential)]
public partial struct DMO_MEDIA_TYPE
{
    public Guid majortype;
    public Guid subtype;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool bFixedSizeSamples;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool bTemporalCompression;
    public uint lSampleSize;
    public Guid formattype;
    public nint pUnk;
    public uint cbFormat;
    public nint pbFormat;
}
