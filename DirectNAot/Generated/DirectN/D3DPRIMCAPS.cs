namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct D3DPRIMCAPS
{
    public uint dwSize;
    public uint dwMiscCaps;
    public uint dwRasterCaps;
    public uint dwZCmpCaps;
    public uint dwSrcBlendCaps;
    public uint dwDestBlendCaps;
    public uint dwAlphaCmpCaps;
    public uint dwShadeCaps;
    public uint dwTextureCaps;
    public uint dwTextureFilterCaps;
    public uint dwTextureBlendCaps;
    public uint dwTextureAddressCaps;
    public uint dwStippleWidth;
    public uint dwStippleHeight;
}
