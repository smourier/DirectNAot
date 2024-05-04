#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct D3DFINDDEVICERESULT
{
    public uint dwSize;
    public Guid guid;
    public D3DDEVICEDESC ddHwDesc;
    public D3DDEVICEDESC ddSwDesc;
}
