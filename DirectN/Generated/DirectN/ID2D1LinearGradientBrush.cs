﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1/nn-d2d1-id2d1lineargradientbrush
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("2cd906ab-12e2-11dc-9fed-001143a055f9")]
public partial interface ID2D1LinearGradientBrush : ID2D1Brush
{
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1lineargradientbrush-setstartpoint
    [PreserveSig]
    void SetStartPoint(D2D_POINT_2F startPoint);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1lineargradientbrush-setendpoint
    [PreserveSig]
    void SetEndPoint(D2D_POINT_2F endPoint);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1lineargradientbrush-getstartpoint
    [PreserveSig]
    D2D_POINT_2F GetStartPoint();
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1lineargradientbrush-getendpoint
    [PreserveSig]
    D2D_POINT_2F GetEndPoint();
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1lineargradientbrush-getgradientstopcollection
    [PreserveSig]
    void GetGradientStopCollection([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1GradientStopCollection>))] out ID2D1GradientStopCollection gradientStopCollection);
}
