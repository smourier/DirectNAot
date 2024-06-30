#nullable enable
namespace DirectN;

public partial struct D3DFINDDEVICERESULT
{
    public uint dwSize;
    public Guid guid;
    public D3DDEVICEDESC ddHwDesc;
    public D3DDEVICEDESC ddSwDesc;
}
