#nullable enable
namespace DirectN;

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
    public HRESULT ddRVal;
    public nint CreateMoComp;
}
