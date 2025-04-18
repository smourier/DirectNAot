#nullable enable
namespace DirectN;

public partial struct DDHAL_GETVPORTFIELDDATA
{
    public nint lpDD;
    public nint lpVideoPort;
    public BOOL bField;
    public HRESULT ddRVal;
    public nint GetVideoPortField;
}
