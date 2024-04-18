namespace DirectN;

// https://learn.microsoft.com/windows/win32/direct3d9/d3dindexbuffer-desc
[StructLayout(LayoutKind.Sequential)]
public partial struct D3DINDEXBUFFER_DESC
{
    public D3DFORMAT Format;
    public D3DRESOURCETYPE Type;
    public uint Usage;
    public D3DPOOL Pool;
    public uint Size;
}
