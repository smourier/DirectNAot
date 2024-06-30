#nullable enable
namespace DirectN;

public partial struct DDHAL_CREATEVPORTDATA
{
    public nint lpDD;
    public nint lpDDVideoPortDesc;
    public nint lpVideoPort;
    public HRESULT ddRVal;
    public nint CreateVideoPort;
}
