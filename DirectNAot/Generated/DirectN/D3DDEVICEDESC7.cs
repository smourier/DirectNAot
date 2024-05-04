#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct D3DDEVICEDESC7
{
    public uint dwDevCaps;
    public D3DPRIMCAPS dpcLineCaps;
    public D3DPRIMCAPS dpcTriCaps;
    public uint dwDeviceRenderBitDepth;
    public uint dwDeviceZBufferBitDepth;
    public uint dwMinTextureWidth;
    public uint dwMinTextureHeight;
    public uint dwMaxTextureWidth;
    public uint dwMaxTextureHeight;
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
    public uint dwMaxActiveLights;
    public float dvMaxVertexW;
    public Guid deviceGUID;
    public ushort wMaxUserClipPlanes;
    public ushort wMaxVertexBlendMatrices;
    public uint dwVertexProcessingCaps;
    public uint dwReserved1;
    public uint dwReserved2;
    public uint dwReserved3;
    public uint dwReserved4;
}
