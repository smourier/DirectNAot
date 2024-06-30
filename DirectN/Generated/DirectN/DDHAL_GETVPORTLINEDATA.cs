#nullable enable
namespace DirectN;

public partial struct DDHAL_GETVPORTLINEDATA
{
    public nint lpDD;
    public nint lpVideoPort;
    public uint dwLine;
    public HRESULT ddRVal;
    public nint GetVideoPortLine;
}
