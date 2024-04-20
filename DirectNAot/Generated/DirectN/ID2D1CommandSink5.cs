namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1_3/nn-d2d1_3-id2d1commandsink5
[GeneratedComInterface, Guid("7047dd26-b1e7-44a7-959a-8349e2144fa8")]
public partial interface ID2D1CommandSink5 : ID2D1CommandSink4
{
    // https://learn.microsoft.com/windows/win32/api/d2d1_3/nf-d2d1_3-id2d1commandsink5-blendimage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT BlendImage(ID2D1Image image, D2D1_BLEND_MODE blendMode, nint /* optional D2D_POINT_2F */ targetOffset, nint /* optional D2D_RECT_F */ imageRectangle, D2D1_INTERPOLATION_MODE interpolationMode);
}
