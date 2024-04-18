namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct D3DDEVICEDESC
{
    public uint dwSize;
    public uint dwFlags;
    public uint dcmColorModel;
    public uint dwDevCaps;
    public D3DTRANSFORMCAPS dtcTransformCaps;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool bClipping;
    public D3DLIGHTINGCAPS dlcLightingCaps;
    public D3DPRIMCAPS dpcLineCaps;
    public D3DPRIMCAPS dpcTriCaps;
    public uint dwDeviceRenderBitDepth;
    public uint dwDeviceZBufferBitDepth;
    public uint dwMaxBufferSize;
    public uint dwMaxVertexCount;
    public uint dwMinTextureWidth;
    public uint dwMinTextureHeight;
    public uint dwMaxTextureWidth;
    public uint dwMaxTextureHeight;
    public uint dwMinStippleWidth;
    public uint dwMaxStippleWidth;
    public uint dwMinStippleHeight;
    public uint dwMaxStippleHeight;
    public uint dwMaxTextureRepeat;
    public uint dwMaxTextureAspectRatio;
    public uint dwMaxAnisotropy;
    public float dvGuardBandLeft;
    public float dvGuardBandTop;
    public float dvGuardBandRight;
    public float dvGuardBandBottom;
    public float dvExtentsAdjust;
    public uint dwStencilCaps;
    public uint dwFVFCaps;
    public uint dwTextureOpCaps;
    public ushort wMaxTextureBlendStages;
    public ushort wMaxSimultaneousTextures;
}
