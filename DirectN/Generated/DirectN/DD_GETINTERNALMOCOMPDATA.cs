#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddrawint/ns-ddrawint-dd_getinternalmocompdata
public partial struct DD_GETINTERNALMOCOMPDATA
{
    public nint lpDD;
    public nint lpGuid;
    public uint dwWidth;
    public uint dwHeight;
    public DDPIXELFORMAT ddPixelFormat;
    public uint dwScratchMemAlloc;
    public HRESULT ddRVal;
}
