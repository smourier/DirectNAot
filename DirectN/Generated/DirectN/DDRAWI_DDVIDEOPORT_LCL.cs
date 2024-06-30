#nullable enable
namespace DirectN;

public partial struct DDRAWI_DDVIDEOPORT_LCL
{
    public nint lpDD;
    public DDVIDEOPORTDESC ddvpDesc;
    public DDVIDEOPORTINFO ddvpInfo;
    public nint lpSurface;
    public nint lpVBISurface;
    public nint lpFlipInts;
    public uint dwNumAutoflip;
    public uint dwProcessID;
    public uint dwStateFlags;
    public uint dwFlags;
    public uint dwRefCnt;
    public nuint fpLastFlip;
    public nuint dwReserved1;
    public nuint dwReserved2;
    public HANDLE hDDVideoPort;
    public uint dwNumVBIAutoflip;
    public nint lpVBIDesc;
    public nint lpVideoDesc;
    public nint lpVBIInfo;
    public nint lpVideoInfo;
    public uint dwVBIProcessID;
    public nint lpVPNotify;
}
