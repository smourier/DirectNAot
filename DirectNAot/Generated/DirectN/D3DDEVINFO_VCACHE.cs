namespace DirectN;

// https://learn.microsoft.com/windows/win32/direct3d9/d3ddevinfo-vcache
[StructLayout(LayoutKind.Sequential)]
public partial struct D3DDEVINFO_VCACHE
{
    public uint Pattern;
    public uint OptMethod;
    public uint CacheSize;
    public uint MagicNumber;
}
