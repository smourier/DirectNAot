namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1_3/ns-d2d1_3-d2d1_ink_style_properties
[StructLayout(LayoutKind.Sequential)]
public partial struct D2D1_INK_STYLE_PROPERTIES
{
    public D2D1_INK_NIB_SHAPE nibShape;
    public D2D_MATRIX_3X2_F nibTransform;
}
