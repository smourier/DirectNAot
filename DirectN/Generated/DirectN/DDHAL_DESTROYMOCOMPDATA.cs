#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DDHAL_DESTROYMOCOMPDATA
{
    public nint lpDD;
    public nint lpMoComp;
    public HRESULT ddRVal;
    public nint DestroyMoComp;
}
