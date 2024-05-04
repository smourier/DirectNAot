#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DD_DESTROYDDLOCALDATA
{
    public uint dwFlags;
    public nint pDDLcl;
    public HRESULT ddRVal;
}
