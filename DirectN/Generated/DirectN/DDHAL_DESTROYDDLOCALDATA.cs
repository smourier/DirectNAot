#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddrawi/ns-ddrawi-ddhal_destroyddlocaldata
[StructLayout(LayoutKind.Sequential)]
public partial struct DDHAL_DESTROYDDLOCALDATA
{
    public uint dwFlags;
    public nint pDDLcl;
    public HRESULT ddRVal;
}
