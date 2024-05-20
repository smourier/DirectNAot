#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DDHAL_GETVPORTFLIPSTATUSDATA
{
    public nint lpDD;
    public nuint fpSurface;
    public HRESULT ddRVal;
    public nint GetVideoPortFlipStatus;
}
