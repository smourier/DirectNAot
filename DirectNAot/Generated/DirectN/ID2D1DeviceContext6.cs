namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1_3/nn-d2d1_3-id2d1devicecontext6
[GeneratedComInterface, Guid("985f7e37-4ed0-4a19-98a3-15b0edfde306")]
public partial interface ID2D1DeviceContext6 : ID2D1DeviceContext5
{
    // https://learn.microsoft.com/windows/win32/api/d2d1_3/nf-d2d1_3-id2d1devicecontext6-blendimage
    [PreserveSig]
    public void BlendImage(ID2D1Image image, D2D1_BLEND_MODE blendMode, nint/* nint */ targetOffset, nint/* nint */ imageRectangle, D2D1_INTERPOLATION_MODE interpolationMode);
}
