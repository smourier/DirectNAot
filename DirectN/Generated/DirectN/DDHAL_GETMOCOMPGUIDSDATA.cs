#nullable enable
namespace DirectN;

public partial struct DDHAL_GETMOCOMPGUIDSDATA
{
    public nint lpDD;
    public uint dwNumGuids;
    public nint lpGuids;
    public HRESULT ddRVal;
    public nint GetMoCompGuids;
}
