namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1/ns-d2d1-d2d1_layer_parameters
[StructLayout(LayoutKind.Sequential)]
public partial struct D2D1_LAYER_PARAMETERS
{
    public D2D_RECT_F contentBounds;
    public nint geometricMask;
    public D2D1_ANTIALIAS_MODE maskAntialiasMode;
    public D2D_MATRIX_3X2_F maskTransform;
    public float opacity;
    public nint opacityBrush;
    public D2D1_LAYER_OPTIONS layerOptions;
}
