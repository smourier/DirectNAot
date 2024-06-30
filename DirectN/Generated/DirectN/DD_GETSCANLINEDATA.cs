#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddrawint/ns-ddrawint-dd_getscanlinedata
public partial struct DD_GETSCANLINEDATA
{
    public nint lpDD;
    public uint dwScanLine;
    public HRESULT ddRVal;
    public nint GetScanLine;
}
