#nullable enable
namespace DirectN;

public partial struct DDHAL_FLIPDATA
{
    public nint lpDD;
    public nint lpSurfCurr;
    public nint lpSurfTarg;
    public uint dwFlags;
    public HRESULT ddRVal;
    public nint Flip;
    public nint lpSurfCurrLeft;
    public nint lpSurfTargLeft;
}
