namespace DirectN;

// https://learn.microsoft.com/windows/win32/direct3d9/d3ddevinfo-resourcemanager
[StructLayout(LayoutKind.Sequential)]
public partial struct D3DDEVINFO_RESOURCEMANAGER
{
    public InlineArrayD3DRESOURCESTATS8 stats;
}
