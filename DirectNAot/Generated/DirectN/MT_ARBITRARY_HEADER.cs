namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfapi/ns-mfapi-mt_arbitrary_header
[StructLayout(LayoutKind.Sequential)]
public partial struct MT_ARBITRARY_HEADER
{
    public Guid majortype;
    public Guid subtype;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool bFixedSizeSamples;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool bTemporalCompression;
    public uint lSampleSize;
    public Guid formattype;
}
