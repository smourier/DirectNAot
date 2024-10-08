﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1/nn-d2d1-id2d1rendertarget
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("2cd90694-12e2-11dc-9fed-001143a055f9")]
public partial interface ID2D1RenderTarget : ID2D1Resource
{
    // https://learn.microsoft.com/windows/win32/Direct2D/id2d1rendertarget-createbitmap
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateBitmap(D2D_SIZE_U size, nint /* optional void* */ srcData, uint pitch, in D2D1_BITMAP_PROPERTIES bitmapProperties, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1Bitmap>))] out ID2D1Bitmap bitmap);
    
    // https://learn.microsoft.com/windows/win32/Direct2D/id2d1rendertarget-createbitmapfromwicbitmap
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateBitmapFromWicBitmap([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWICBitmapSource>))] IWICBitmapSource wicBitmapSource, nint /* optional D2D1_BITMAP_PROPERTIES* */ bitmapProperties, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1Bitmap>))] out ID2D1Bitmap bitmap);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1rendertarget-createsharedbitmap
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateSharedBitmap(in Guid riid, nint data, nint /* optional D2D1_BITMAP_PROPERTIES* */ bitmapProperties, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1Bitmap>))] out ID2D1Bitmap bitmap);
    
    // https://learn.microsoft.com/windows/win32/Direct2D/id2d1rendertarget-createbitmapbrush
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateBitmapBrush([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1Bitmap?>))] ID2D1Bitmap? bitmap, nint /* optional D2D1_BITMAP_BRUSH_PROPERTIES* */ bitmapBrushProperties, nint /* optional D2D1_BRUSH_PROPERTIES* */ brushProperties, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1BitmapBrush>))] out ID2D1BitmapBrush bitmapBrush);
    
    // https://learn.microsoft.com/windows/win32/Direct2D/id2d1rendertarget-createsolidcolorbrush
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateSolidColorBrush(in D3DCOLORVALUE color, nint /* optional D2D1_BRUSH_PROPERTIES* */ brushProperties, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1SolidColorBrush>))] out ID2D1SolidColorBrush solidColorBrush);
    
    // https://learn.microsoft.com/windows/win32/Direct2D/id2d1rendertarget-creategradientstopcollection
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateGradientStopCollection([In][MarshalUsing(CountElementName = nameof(gradientStopsCount))] D2D1_GRADIENT_STOP[] gradientStops, uint gradientStopsCount, D2D1_GAMMA colorInterpolationGamma, D2D1_EXTEND_MODE extendMode, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1GradientStopCollection>))] out ID2D1GradientStopCollection gradientStopCollection);
    
    // https://learn.microsoft.com/windows/win32/Direct2D/id2d1rendertarget-createlineargradientbrush
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateLinearGradientBrush(in D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES linearGradientBrushProperties, nint /* optional D2D1_BRUSH_PROPERTIES* */ brushProperties, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1GradientStopCollection>))] ID2D1GradientStopCollection gradientStopCollection, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1LinearGradientBrush>))] out ID2D1LinearGradientBrush linearGradientBrush);
    
    // https://learn.microsoft.com/windows/win32/Direct2D/id2d1rendertarget-createradialgradientbrush
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateRadialGradientBrush(in D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES radialGradientBrushProperties, nint /* optional D2D1_BRUSH_PROPERTIES* */ brushProperties, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1GradientStopCollection>))] ID2D1GradientStopCollection gradientStopCollection, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1RadialGradientBrush>))] out ID2D1RadialGradientBrush radialGradientBrush);
    
    // https://learn.microsoft.com/windows/win32/Direct2D/id2d1rendertarget-createcompatiblerendertarget
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateCompatibleRenderTarget(nint /* optional D2D_SIZE_F* */ desiredSize, nint /* optional D2D_SIZE_U* */ desiredPixelSize, nint /* optional D2D1_PIXEL_FORMAT* */ desiredFormat, D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS options, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1BitmapRenderTarget>))] out ID2D1BitmapRenderTarget bitmapRenderTarget);
    
    // https://learn.microsoft.com/windows/win32/Direct2D/id2d1rendertarget-createlayer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateLayer(nint /* optional D2D_SIZE_F* */ size, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1Layer>))] out ID2D1Layer layer);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1rendertarget-createmesh
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateMesh([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1Mesh>))] out ID2D1Mesh mesh);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1rendertarget-drawline
    [PreserveSig]
    void DrawLine(D2D_POINT_2F point0, D2D_POINT_2F point1, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1Brush>))] ID2D1Brush brush, float strokeWidth, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1StrokeStyle?>))] ID2D1StrokeStyle? strokeStyle);
    
    // https://learn.microsoft.com/windows/win32/Direct2D/id2d1rendertarget-drawrectangle
    [PreserveSig]
    void DrawRectangle(in D2D_RECT_F rect, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1Brush>))] ID2D1Brush brush, float strokeWidth, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1StrokeStyle?>))] ID2D1StrokeStyle? strokeStyle);
    
    // https://learn.microsoft.com/windows/win32/Direct2D/id2d1rendertarget-fillrectangle
    [PreserveSig]
    void FillRectangle(in D2D_RECT_F rect, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1Brush>))] ID2D1Brush brush);
    
    // https://learn.microsoft.com/windows/win32/Direct2D/id2d1rendertarget-drawroundedrectangle
    [PreserveSig]
    void DrawRoundedRectangle(in D2D1_ROUNDED_RECT roundedRect, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1Brush>))] ID2D1Brush brush, float strokeWidth, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1StrokeStyle?>))] ID2D1StrokeStyle? strokeStyle);
    
    // https://learn.microsoft.com/windows/win32/Direct2D/id2d1rendertarget-fillroundedrectangle
    [PreserveSig]
    void FillRoundedRectangle(in D2D1_ROUNDED_RECT roundedRect, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1Brush>))] ID2D1Brush brush);
    
    // https://learn.microsoft.com/windows/win32/Direct2D/id2d1rendertarget-drawellipse
    [PreserveSig]
    void DrawEllipse(in D2D1_ELLIPSE ellipse, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1Brush>))] ID2D1Brush brush, float strokeWidth, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1StrokeStyle?>))] ID2D1StrokeStyle? strokeStyle);
    
    // https://learn.microsoft.com/windows/win32/Direct2D/id2d1rendertarget-fillellipse
    [PreserveSig]
    void FillEllipse(in D2D1_ELLIPSE ellipse, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1Brush>))] ID2D1Brush brush);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1rendertarget-drawgeometry
    [PreserveSig]
    void DrawGeometry([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1Geometry>))] ID2D1Geometry geometry, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1Brush>))] ID2D1Brush brush, float strokeWidth, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1StrokeStyle?>))] ID2D1StrokeStyle? strokeStyle);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1rendertarget-fillgeometry
    [PreserveSig]
    void FillGeometry([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1Geometry>))] ID2D1Geometry geometry, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1Brush>))] ID2D1Brush brush, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1Brush?>))] ID2D1Brush? opacityBrush);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1rendertarget-fillmesh
    [PreserveSig]
    void FillMesh([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1Mesh>))] ID2D1Mesh mesh, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1Brush>))] ID2D1Brush brush);
    
    // https://learn.microsoft.com/windows/win32/Direct2D/id2d1rendertarget-fillopacitymask
    [PreserveSig]
    void FillOpacityMask([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1Bitmap>))] ID2D1Bitmap opacityMask, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1Brush>))] ID2D1Brush brush, D2D1_OPACITY_MASK_CONTENT content, nint /* optional D2D_RECT_F* */ destinationRectangle, nint /* optional D2D_RECT_F* */ sourceRectangle);
    
    // https://learn.microsoft.com/windows/win32/Direct2D/id2d1rendertarget-drawbitmap
    [PreserveSig]
    void DrawBitmap([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1Bitmap>))] ID2D1Bitmap bitmap, nint /* optional D2D_RECT_F* */ destinationRectangle, float opacity, D2D1_BITMAP_INTERPOLATION_MODE interpolationMode, nint /* optional D2D_RECT_F* */ sourceRectangle);
    
    // https://learn.microsoft.com/windows/win32/Direct2D/id2d1rendertarget-drawtext
    [PreserveSig]
    void DrawText([MarshalUsing(CountElementName = nameof(stringLength))] PWSTR @string, uint stringLength, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteTextFormat>))] IDWriteTextFormat textFormat, in D2D_RECT_F layoutRect, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1Brush>))] ID2D1Brush defaultFillBrush, D2D1_DRAW_TEXT_OPTIONS options, DWRITE_MEASURING_MODE measuringMode);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1rendertarget-drawtextlayout
    [PreserveSig]
    void DrawTextLayout(D2D_POINT_2F origin, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteTextLayout>))] IDWriteTextLayout textLayout, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1Brush>))] ID2D1Brush defaultFillBrush, D2D1_DRAW_TEXT_OPTIONS options);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1rendertarget-drawglyphrun
    [PreserveSig]
    void DrawGlyphRun(D2D_POINT_2F baselineOrigin, in DWRITE_GLYPH_RUN glyphRun, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1Brush>))] ID2D1Brush foregroundBrush, DWRITE_MEASURING_MODE measuringMode);
    
    // https://learn.microsoft.com/windows/win32/Direct2D/id2d1rendertarget-settransform
    [PreserveSig]
    void SetTransform(in D2D_MATRIX_3X2_F transform);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1rendertarget-gettransform
    [PreserveSig]
    void GetTransform(out D2D_MATRIX_3X2_F transform);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1rendertarget-setantialiasmode
    [PreserveSig]
    void SetAntialiasMode(D2D1_ANTIALIAS_MODE antialiasMode);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1rendertarget-getantialiasmode
    [PreserveSig]
    D2D1_ANTIALIAS_MODE GetAntialiasMode();
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1rendertarget-settextantialiasmode
    [PreserveSig]
    void SetTextAntialiasMode(D2D1_TEXT_ANTIALIAS_MODE textAntialiasMode);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1rendertarget-gettextantialiasmode
    [PreserveSig]
    D2D1_TEXT_ANTIALIAS_MODE GetTextAntialiasMode();
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1rendertarget-settextrenderingparams
    [PreserveSig]
    void SetTextRenderingParams([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteRenderingParams?>))] IDWriteRenderingParams? textRenderingParams);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1rendertarget-gettextrenderingparams
    [PreserveSig]
    void GetTextRenderingParams([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteRenderingParams>))] out IDWriteRenderingParams textRenderingParams);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1rendertarget-settags
    [PreserveSig]
    void SetTags(ulong tag1, ulong tag2);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1rendertarget-gettags
    [PreserveSig]
    void GetTags(nint /* optional ulong* */ tag1, nint /* optional ulong* */ tag2);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1rendertarget-pushlayer(constd2d1_layer_parameters_id2d1layer)
    [PreserveSig]
    void PushLayer(in D2D1_LAYER_PARAMETERS layerParameters, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1Layer?>))] ID2D1Layer? layer);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1rendertarget-poplayer
    [PreserveSig]
    void PopLayer();
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1rendertarget-flush
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Flush(nint /* optional ulong* */ tag1, nint /* optional ulong* */ tag2);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1rendertarget-savedrawingstate
    [PreserveSig]
    void SaveDrawingState([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1DrawingStateBlock>))] ID2D1DrawingStateBlock drawingStateBlock);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1rendertarget-restoredrawingstate
    [PreserveSig]
    void RestoreDrawingState([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1DrawingStateBlock>))] ID2D1DrawingStateBlock drawingStateBlock);
    
    // https://learn.microsoft.com/windows/win32/Direct2D/id2d1rendertarget-pushaxisalignedclip
    [PreserveSig]
    void PushAxisAlignedClip(in D2D_RECT_F clipRect, D2D1_ANTIALIAS_MODE antialiasMode);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1rendertarget-popaxisalignedclip
    [PreserveSig]
    void PopAxisAlignedClip();
    
    // https://learn.microsoft.com/windows/win32/Direct2D/id2d1rendertarget-clear
    [PreserveSig]
    void Clear(nint /* optional D3DCOLORVALUE* */ clearColor);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1rendertarget-begindraw
    [PreserveSig]
    void BeginDraw();
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1rendertarget-enddraw
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EndDraw(nint /* optional ulong* */ tag1, nint /* optional ulong* */ tag2);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1rendertarget-getpixelformat
    [PreserveSig]
    D2D1_PIXEL_FORMAT GetPixelFormat();
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1rendertarget-setdpi
    [PreserveSig]
    void SetDpi(float dpiX, float dpiY);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1rendertarget-getdpi
    [PreserveSig]
    void GetDpi(out float dpiX, out float dpiY);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1rendertarget-getsize
    [PreserveSig]
    D2D_SIZE_F GetSize();
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1rendertarget-getpixelsize
    [PreserveSig]
    D2D_SIZE_U GetPixelSize();
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1rendertarget-getmaximumbitmapsize
    [PreserveSig]
    uint GetMaximumBitmapSize();
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1rendertarget-issupported(constd2d1_render_target_properties_)
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    BOOL IsSupported(in D2D1_RENDER_TARGET_PROPERTIES renderTargetProperties);
}
