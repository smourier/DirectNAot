namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KS_DATARANGE_VIDEO_PALETTE
{
    public KSDATAFORMAT DataRange;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool bFixedSizeSamples;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool bTemporalCompression;
    public uint StreamDescriptionFlags;
    public uint MemoryAllocationFlags;
    public KS_VIDEO_STREAM_CONFIG_CAPS ConfigCaps;
    public KS_VIDEOINFO VideoInfo;
}
