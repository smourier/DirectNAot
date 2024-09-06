#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1/nn-d2d1-id2d1factory
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("06152247-6f50-465a-9245-118bfd3b6007")]
public partial interface ID2D1Factory
{
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1factory-reloadsystemmetrics
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ReloadSystemMetrics();
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1factory-getdesktopdpi
    [PreserveSig]
    void GetDesktopDpi(out float dpiX, out float dpiY);
    
    // https://learn.microsoft.com/windows/win32/Direct2D/id2d1factory-createrectanglegeometry
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateRectangleGeometry(in D2D_RECT_F rectangle, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1RectangleGeometry>))] out ID2D1RectangleGeometry rectangleGeometry);
    
    // https://learn.microsoft.com/windows/win32/Direct2D/id2d1factory-createroundedrectanglegeometry
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateRoundedRectangleGeometry(in D2D1_ROUNDED_RECT roundedRectangle, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1RoundedRectangleGeometry>))] out ID2D1RoundedRectangleGeometry roundedRectangleGeometry);
    
    // https://learn.microsoft.com/windows/win32/Direct2D/id2d1factory-createellipsegeometry
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateEllipseGeometry(in D2D1_ELLIPSE ellipse, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1EllipseGeometry>))] out ID2D1EllipseGeometry ellipseGeometry);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1factory-creategeometrygroup
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateGeometryGroup(D2D1_FILL_MODE fillMode, [In][MarshalUsing(CountElementName = nameof(geometriesCount))] ID2D1Geometry[] geometries, uint geometriesCount, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1GeometryGroup>))] out ID2D1GeometryGroup geometryGroup);
    
    // https://learn.microsoft.com/windows/win32/Direct2D/id2d1factory-createtransformedgeometry
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateTransformedGeometry(ID2D1Geometry sourceGeometry, in D2D_MATRIX_3X2_F transform, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1TransformedGeometry>))] out ID2D1TransformedGeometry transformedGeometry);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1factory-createpathgeometry
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreatePathGeometry([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1PathGeometry>))] out ID2D1PathGeometry pathGeometry);
    
    // https://learn.microsoft.com/windows/win32/Direct2D/id2d1factory-createstrokestyle
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateStrokeStyle(in D2D1_STROKE_STYLE_PROPERTIES strokeStyleProperties, nint /* optional float* */ dashes, uint dashesCount, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1StrokeStyle>))] out ID2D1StrokeStyle strokeStyle);
    
    // https://learn.microsoft.com/windows/win32/Direct2D/id2d1factory-createdrawingstateblock
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateDrawingStateBlock(nint /* optional D2D1_DRAWING_STATE_DESCRIPTION* */ drawingStateDescription, IDWriteRenderingParams? textRenderingParams, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1DrawingStateBlock>))] out ID2D1DrawingStateBlock drawingStateBlock);
    
    // https://learn.microsoft.com/windows/win32/Direct2D/id2d1factory-createwicbitmaprendertarget
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateWicBitmapRenderTarget(IWICBitmap target, in D2D1_RENDER_TARGET_PROPERTIES renderTargetProperties, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1RenderTarget>))] out ID2D1RenderTarget renderTarget);
    
    // https://learn.microsoft.com/windows/win32/Direct2D/id2d1factory-createhwndrendertarget
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateHwndRenderTarget(in D2D1_RENDER_TARGET_PROPERTIES renderTargetProperties, in D2D1_HWND_RENDER_TARGET_PROPERTIES hwndRenderTargetProperties, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1HwndRenderTarget>))] out ID2D1HwndRenderTarget hwndRenderTarget);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1factory-createdxgisurfacerendertarget(idxgisurface_constd2d1_render_target_properties__id2d1rendertarget)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateDxgiSurfaceRenderTarget(IDXGISurface dxgiSurface, in D2D1_RENDER_TARGET_PROPERTIES renderTargetProperties, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1RenderTarget>))] out ID2D1RenderTarget renderTarget);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1factory-createdcrendertarget
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateDCRenderTarget(in D2D1_RENDER_TARGET_PROPERTIES renderTargetProperties, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1DCRenderTarget>))] out ID2D1DCRenderTarget dcRenderTarget);
}
