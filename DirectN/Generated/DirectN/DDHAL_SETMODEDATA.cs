#nullable enable
namespace DirectN;

public partial struct DDHAL_SETMODEDATA
{
    public nint lpDD;
    public uint dwModeIndex;
    public HRESULT ddRVal;
    public nint SetMode;
    public BOOL inexcl;
    public BOOL useRefreshRate;
}
