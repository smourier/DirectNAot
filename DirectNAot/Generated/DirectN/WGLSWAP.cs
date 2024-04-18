namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct WGLSWAP
{
    public HDC hdc;
    public uint uiFlags;
}
