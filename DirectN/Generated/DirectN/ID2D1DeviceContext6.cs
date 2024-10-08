﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1_3/nn-d2d1_3-id2d1devicecontext6
[GeneratedComInterface, Guid("985f7e37-4ed0-4a19-98a3-15b0edfde306")]
public partial interface ID2D1DeviceContext6 : ID2D1DeviceContext5
{
    // https://learn.microsoft.com/windows/win32/api/d2d1_3/nf-d2d1_3-id2d1devicecontext6-blendimage
    [PreserveSig]
    void BlendImage([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1Image>))] ID2D1Image image, D2D1_BLEND_MODE blendMode, nint /* optional D2D_POINT_2F* */ targetOffset, nint /* optional D2D_RECT_F* */ imageRectangle, D2D1_INTERPOLATION_MODE interpolationMode);
}
