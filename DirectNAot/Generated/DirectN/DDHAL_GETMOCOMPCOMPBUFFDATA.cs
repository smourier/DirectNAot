#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DDHAL_GETMOCOMPCOMPBUFFDATA
{
    public nint lpDD;
    public nint lpGuid;
    public uint dwWidth;
    public uint dwHeight;
    public DDPIXELFORMAT ddPixelFormat;
    public uint dwNumTypesCompBuffs;
    public nint lpCompBuffInfo;
    public HRESULT ddRVal;
    public nint GetMoCompBuffInfo;
}
