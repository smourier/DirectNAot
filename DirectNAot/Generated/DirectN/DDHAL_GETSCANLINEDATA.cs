#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DDHAL_GETSCANLINEDATA
{
    public nint lpDD;
    public uint dwScanLine;
    public HRESULT ddRVal;
    public nint GetScanLine;
}
