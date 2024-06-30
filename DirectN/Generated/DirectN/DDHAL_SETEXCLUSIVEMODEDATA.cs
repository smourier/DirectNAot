#nullable enable
namespace DirectN;

public partial struct DDHAL_SETEXCLUSIVEMODEDATA
{
    public nint lpDD;
    public uint dwEnterExcl;
    public uint dwReserved;
    public HRESULT ddRVal;
    public nint SetExclusiveMode;
}
