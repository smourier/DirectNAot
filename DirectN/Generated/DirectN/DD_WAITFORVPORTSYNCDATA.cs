#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddrawint/ns-ddrawint-dd_waitforvportsyncdata
public partial struct DD_WAITFORVPORTSYNCDATA
{
    public nint lpDD;
    public nint lpVideoPort;
    public uint dwFlags;
    public uint dwLine;
    public uint dwTimeOut;
    public HRESULT ddRVal;
    public nint UpdateVideoPort;
}
