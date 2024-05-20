#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddrawint/ns-ddrawint-dd_getmocompcompbuffdata
[StructLayout(LayoutKind.Sequential)]
public partial struct DD_GETMOCOMPCOMPBUFFDATA
{
    public nint lpDD;
    public nint lpGuid;
    public uint dwWidth;
    public uint dwHeight;
    public DDPIXELFORMAT ddPixelFormat;
    public uint dwNumTypesCompBuffs;
    public nint lpCompBuffInfo;
    public HRESULT ddRVal;
}
