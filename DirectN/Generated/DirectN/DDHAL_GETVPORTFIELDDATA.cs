#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DDHAL_GETVPORTFIELDDATA
{
    public nint lpDD;
    public nint lpVideoPort;
    public BOOL bField;
    public HRESULT ddRVal;
    public nint GetVideoPortField;
}
