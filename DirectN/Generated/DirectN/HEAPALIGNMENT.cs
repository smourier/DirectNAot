#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dmemmgr/ns-dmemmgr-heapalignment
[StructLayout(LayoutKind.Sequential)]
public partial struct HEAPALIGNMENT
{
    public uint dwSize;
    public DDSCAPS ddsCaps;
    public uint dwReserved;
    public SURFACEALIGNMENT ExecuteBuffer;
    public SURFACEALIGNMENT Overlay;
    public SURFACEALIGNMENT Texture;
    public SURFACEALIGNMENT ZBuffer;
    public SURFACEALIGNMENT AlphaBuffer;
    public SURFACEALIGNMENT Offscreen;
    public SURFACEALIGNMENT FlipTarget;
}
