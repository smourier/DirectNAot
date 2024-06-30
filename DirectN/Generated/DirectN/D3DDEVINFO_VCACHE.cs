#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/direct3d9/d3ddevinfo-vcache
public partial struct D3DDEVINFO_VCACHE
{
    public uint Pattern;
    public uint OptMethod;
    public uint CacheSize;
    public uint MagicNumber;
}
