namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DDHAL_CREATEMOCOMPDATA
{
    public nint lpDD;
    public nint lpMoComp;
    public nint lpGuid;
    public uint dwUncompWidth;
    public uint dwUncompHeight;
    public DDPIXELFORMAT ddUncompPixelFormat;
    public nint lpData;
    public uint dwDataSize;
    
    [MarshalAs(UnmanagedType.Error)]
    public HRESULT ddRVal;
    public nint CreateMoComp;
}
