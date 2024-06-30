#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddrawint/ns-ddrawint-dd_updatevportdata
public partial struct DD_UPDATEVPORTDATA
{
    public nint lpDD;
    public nint lpVideoPort;
    public nint lplpDDSurface;
    public nint lplpDDVBISurface;
    public nint lpVideoInfo;
    public uint dwFlags;
    public uint dwNumAutoflip;
    public uint dwNumVBIAutoflip;
    public HRESULT ddRVal;
    public nint UpdateVideoPort;
}
