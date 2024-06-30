#nullable enable
namespace DirectN;

public partial struct DDHAL_GETDRIVERINFODATA
{
    public uint dwSize;
    public uint dwFlags;
    public Guid guidInfo;
    public uint dwExpectedSize;
    public nint lpvData;
    public uint dwActualSize;
    public HRESULT ddRVal;
    public nuint dwContext;
}
