namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DDHAL_GETVPORTBANDWIDTHDATA
{
    public nint lpDD;
    public nint lpVideoPort;
    public nint lpddpfFormat;
    public uint dwWidth;
    public uint dwHeight;
    public uint dwFlags;
    public nint lpBandwidth;
    
    [MarshalAs(UnmanagedType.Error)]
    public HRESULT ddRVal;
    public nint GetVideoPortBandwidth;
}
