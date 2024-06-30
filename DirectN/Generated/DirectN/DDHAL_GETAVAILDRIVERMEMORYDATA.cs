#nullable enable
namespace DirectN;

public partial struct DDHAL_GETAVAILDRIVERMEMORYDATA
{
    public nint lpDD;
    public DDSCAPS DDSCaps;
    public uint dwTotal;
    public uint dwFree;
    public HRESULT ddRVal;
    public nint GetAvailDriverMemory;
    public DDSCAPSEX ddsCapsEx;
}
