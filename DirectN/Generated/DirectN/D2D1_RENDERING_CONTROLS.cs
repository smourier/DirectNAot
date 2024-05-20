#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1_1/ns-d2d1_1-d2d1_rendering_controls
[StructLayout(LayoutKind.Sequential)]
public partial struct D2D1_RENDERING_CONTROLS
{
    public D2D1_BUFFER_PRECISION bufferPrecision;
    public D2D_SIZE_U tileSize;
}
