#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DDHAL_DESTROYDRIVERDATA
{
    public nint lpDD;
    public HRESULT ddRVal;
    public nint DestroyDriver;
}
