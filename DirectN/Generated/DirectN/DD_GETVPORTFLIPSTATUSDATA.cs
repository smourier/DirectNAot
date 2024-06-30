#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddrawint/ns-ddrawint-dd_getvportflipstatusdata
public partial struct DD_GETVPORTFLIPSTATUSDATA
{
    public nint lpDD;
    public nuint fpSurface;
    public HRESULT ddRVal;
    public nint GetVideoPortFlipStatus;
}
