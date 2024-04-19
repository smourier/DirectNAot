namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DDHAL_GETINTERNALMOCOMPDATA
{
    public nint lpDD;
    public nint lpGuid;
    public uint dwWidth;
    public uint dwHeight;
    public DDPIXELFORMAT ddPixelFormat;
    public uint dwScratchMemAlloc;
    public HRESULT ddRVal;
    public nint GetInternalMoCompInfo;
}
