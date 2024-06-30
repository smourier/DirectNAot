#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddrawint/ns-ddrawint-dd_videoport_local
public partial struct DD_VIDEOPORT_LOCAL
{
    public nint lpDD;
    public DDVIDEOPORTDESC ddvpDesc;
    public DDVIDEOPORTINFO ddvpInfo;
    public nint lpSurface;
    public nint lpVBISurface;
    public uint dwNumAutoflip;
    public uint dwNumVBIAutoflip;
    public nuint dwReserved1;
    public nuint dwReserved2;
    public nuint dwReserved3;
}
