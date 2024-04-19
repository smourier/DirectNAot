namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_FEATURE_DATA_VIDEO_FEATURE_AREA_SUPPORT
{
    public uint NodeIndex;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool VideoDecodeSupport;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool VideoProcessSupport;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool VideoEncodeSupport;
}
