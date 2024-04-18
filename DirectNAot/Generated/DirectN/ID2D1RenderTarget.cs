namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1/nn-d2d1-id2d1rendertarget
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("2cd90694-12e2-11dc-9fed-001143a055f9")]
public partial interface ID2D1RenderTarget : ID2D1Resource
{
    // https://learn.microsoft.com/windows/win32/Direct2D/id2d1rendertarget-createbitmap
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateBitmap(D2D_SIZE_U size, nint /* void */ srcData, uint pitch, in D2D1_BITMAP_PROPERTIES bitmapProperties, out ID2D1Bitmap bitmap);
    
    // https://learn.microsoft.com/windows/win32/Direct2D/id2d1rendertarget-createbitmapfromwicbitmap
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateBitmapFromWicBitmap(IWICBitmapSource wicBitmapSource, nint /* D2D1_BITMAP_PROPERTIES */ bitmapProperties, out ID2D1Bitmap bitmap);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1rendertarget-createsharedbitmap
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateSharedBitmap(in Guid riid, nint data, nint /* D2D1_BITMAP_PROPERTIES */ bitmapProperties, out ID2D1Bitmap bitmap);
    
    // https://learn.microsoft.com/windows/win32/Direct2D/id2d1rendertarget-createbitmapbrush
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateBitmapBrush(ID2D1Bitmap bitmap, nint /* D2D1_BITMAP_BRUSH_PROPERTIES */ bitmapBrushProperties, nint /* D2D1_BRUSH_PROPERTIES */ brushProperties, out ID2D1BitmapBrush bitmapBrush);
    
    // https://learn.microsoft.com/windows/win32/Direct2D/id2d1rendertarget-createsolidcolorbrush
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateSolidColorBrush(in D2D1_COLOR_F color, nint /* D2D1_BRUSH_PROPERTIES */ brushProperties, out ID2D1SolidColorBrush solidColorBrush);
    
    // https://learn.microsoft.com/windows/win32/Direct2D/id2d1rendertarget-creategradientstopcollection
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateGradientStopCollection(in D2D1_GRADIENT_STOP gradientStops, uint gradientStopsCount, D2D1_GAMMA colorInterpolationGamma, D2D1_EXTEND_MODE extendMode, out ID2D1GradientStopCollection gradientStopCollection);
    
    // https://learn.microsoft.com/windows/win32/Direct2D/id2d1rendertarget-createlineargradientbrush
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateLinearGradientBrush(in D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES linearGradientBrushProperties, nint /* D2D1_BRUSH_PROPERTIES */ brushProperties, ID2D1GradientStopCollection gradientStopCollection, out ID2D1LinearGradientBrush linearGradientBrush);
    
    // https://learn.microsoft.com/windows/win32/Direct2D/id2d1rendertarget-createradialgradientbrush
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateRadialGradientBrush(in D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES radialGradientBrushProperties, nint /* D2D1_BRUSH_PROPERTIES */ brushProperties, ID2D1GradientStopCollection gradientStopCollection, out ID2D1RadialGradientBrush radialGradientBrush);
    
    // https://learn.microsoft.com/windows/win32/Direct2D/id2d1rendertarget-createcompatiblerendertarget
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateCompatibleRenderTarget(nint /* D2D_SIZE_F */ desiredSize, nint /* D2D_SIZE_U */ desiredPixelSize, nint /* D2D1_PIXEL_FORMAT */ desiredFormat, D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS options, out ID2D1BitmapRenderTarget bitmapRenderTarget);
    
    // https://learn.microsoft.com/windows/win32/Direct2D/id2d1rendertarget-createlayer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateLayer(nint /* D2D_SIZE_F */ size, out ID2D1Layer layer);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1rendertarget-createmesh
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateMesh(out ID2D1Mesh mesh);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1rendertarget-drawline
    [PreserveSig]
    public void DrawLine(D2D_POINT_2F point0, D2D_POINT_2F point1, ID2D1Brush brush, float strokeWidth, ID2D1StrokeStyle strokeStyle);
    
    // https://learn.microsoft.com/windows/win32/Direct2D/id2d1rendertarget-drawrectangle
    [PreserveSig]
    public void DrawRectangle(in D2D_RECT_F rect, ID2D1Brush brush, float strokeWidth, ID2D1StrokeStyle strokeStyle);
    
    // https://learn.microsoft.com/windows/win32/Direct2D/id2d1rendertarget-fillrectangle
    [PreserveSig]
    public void FillRectangle(in D2D_RECT_F rect, ID2D1Brush brush);
    
    // https://learn.microsoft.com/windows/win32/Direct2D/id2d1rendertarget-drawroundedrectangle
    [PreserveSig]
    public void DrawRoundedRectangle(in D2D1_ROUNDED_RECT roundedRect, ID2D1Brush brush, float strokeWidth, ID2D1StrokeStyle strokeStyle);
    
    // https://learn.microsoft.com/windows/win32/Direct2D/id2d1rendertarget-fillroundedrectangle
    [PreserveSig]
    public void FillRoundedRectangle(in D2D1_ROUNDED_RECT roundedRect, ID2D1Brush brush);
    
    // https://learn.microsoft.com/windows/win32/Direct2D/id2d1rendertarget-drawellipse
    [PreserveSig]
    public void DrawEllipse(in D2D1_ELLIPSE ellipse, ID2D1Brush brush, float strokeWidth, ID2D1StrokeStyle strokeStyle);
    
    // https://learn.microsoft.com/windows/win32/Direct2D/id2d1rendertarget-fillellipse
    [PreserveSig]
    public void FillEllipse(in D2D1_ELLIPSE ellipse, ID2D1Brush brush);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1rendertarget-drawgeometry
    [PreserveSig]
    public void DrawGeometry(ID2D1Geometry geometry, ID2D1Brush brush, float strokeWidth, ID2D1StrokeStyle strokeStyle);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1rendertarget-fillgeometry
    [PreserveSig]
    public void FillGeometry(ID2D1Geometry geometry, ID2D1Brush brush, ID2D1Brush opacityBrush);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1rendertarget-fillmesh
    [PreserveSig]
    public void FillMesh(ID2D1Mesh mesh, ID2D1Brush brush);
    
    // https://learn.microsoft.com/windows/win32/Direct2D/id2d1rendertarget-fillopacitymask
    [PreserveSig]
    public void FillOpacityMask(ID2D1Bitmap opacityMask, ID2D1Brush brush, D2D1_OPACITY_MASK_CONTENT content, nint /* D2D_RECT_F */ destinationRectangle, nint /* D2D_RECT_F */ sourceRectangle);
    
    // https://learn.microsoft.com/windows/win32/Direct2D/id2d1rendertarget-drawbitmap
    [PreserveSig]
    public void DrawBitmap(ID2D1Bitmap bitmap, nint /* D2D_RECT_F */ destinationRectangle, float opacity, D2D1_BITMAP_INTERPOLATION_MODE interpolationMode, nint /* D2D_RECT_F */ sourceRectangle);
    
    // https://learn.microsoft.com/windows/win32/Direct2D/id2d1rendertarget-drawtext
    [PreserveSig]
    public void DrawText(PWSTR @string, uint stringLength, IDWriteTextFormat textFormat, in D2D_RECT_F layoutRect, ID2D1Brush defaultFillBrush, D2D1_DRAW_TEXT_OPTIONS options, DWRITE_MEASURING_MODE measuringMode);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1rendertarget-drawtextlayout
    [PreserveSig]
    public void DrawTextLayout(D2D_POINT_2F origin, IDWriteTextLayout textLayout, ID2D1Brush defaultFillBrush, D2D1_DRAW_TEXT_OPTIONS options);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1rendertarget-drawglyphrun
    [PreserveSig]
    public void DrawGlyphRun(D2D_POINT_2F baselineOrigin, in DWRITE_GLYPH_RUN glyphRun, ID2D1Brush foregroundBrush, DWRITE_MEASURING_MODE measuringMode);
    
    // https://learn.microsoft.com/windows/win32/Direct2D/id2d1rendertarget-settransform
    [PreserveSig]
    public void SetTransform(in D2D_MATRIX_3X2_F transform);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1rendertarget-gettransform
    [PreserveSig]
    public void GetTransform(out D2D_MATRIX_3X2_F transform);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1rendertarget-setantialiasmode
    [PreserveSig]
    public void SetAntialiasMode(D2D1_ANTIALIAS_MODE antialiasMode);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1rendertarget-getantialiasmode
    [PreserveSig]
    public D2D1_ANTIALIAS_MODE GetAntialiasMode();
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1rendertarget-settextantialiasmode
    [PreserveSig]
    public void SetTextAntialiasMode(D2D1_TEXT_ANTIALIAS_MODE textAntialiasMode);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1rendertarget-gettextantialiasmode
    [PreserveSig]
    public D2D1_TEXT_ANTIALIAS_MODE GetTextAntialiasMode();
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1rendertarget-settextrenderingparams
    [PreserveSig]
    public void SetTextRenderingParams(IDWriteRenderingParams textRenderingParams);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1rendertarget-gettextrenderingparams
    [PreserveSig]
    public void GetTextRenderingParams(out IDWriteRenderingParams textRenderingParams);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1rendertarget-settags
    [PreserveSig]
    public void SetTags(ulong tag1, ulong tag2);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1rendertarget-gettags
    [PreserveSig]
    public void GetTags(nint /* ulong */ tag1, nint /* ulong */ tag2);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1rendertarget-pushlayer(constd2d1_layer_parameters_id2d1layer)
    [PreserveSig]
    public void PushLayer(in D2D1_LAYER_PARAMETERS layerParameters, ID2D1Layer layer);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1rendertarget-poplayer
    [PreserveSig]
    public void PopLayer();
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1rendertarget-flush
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT Flush(nint /* ulong */ tag1, nint /* ulong */ tag2);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1rendertarget-savedrawingstate
    [PreserveSig]
    public void SaveDrawingState(ID2D1DrawingStateBlock drawingStateBlock);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1rendertarget-restoredrawingstate
    [PreserveSig]
    public void RestoreDrawingState(ID2D1DrawingStateBlock drawingStateBlock);
    
    // https://learn.microsoft.com/windows/win32/Direct2D/id2d1rendertarget-pushaxisalignedclip
    [PreserveSig]
    public void PushAxisAlignedClip(in D2D_RECT_F clipRect, D2D1_ANTIALIAS_MODE antialiasMode);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1rendertarget-popaxisalignedclip
    [PreserveSig]
    public void PopAxisAlignedClip();
    
    // https://learn.microsoft.com/windows/win32/Direct2D/id2d1rendertarget-clear
    [PreserveSig]
    public void Clear(nint /* D2D1_COLOR_F */ clearColor);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1rendertarget-begindraw
    [PreserveSig]
    public void BeginDraw();
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1rendertarget-enddraw
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT EndDraw(nint /* ulong */ tag1, nint /* ulong */ tag2);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1rendertarget-getpixelformat
    [PreserveSig]
    public D2D1_PIXEL_FORMAT GetPixelFormat();
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1rendertarget-setdpi
    [PreserveSig]
    public void SetDpi(float dpiX, float dpiY);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1rendertarget-getdpi
    [PreserveSig]
    public void GetDpi(out float dpiX, out float dpiY);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1rendertarget-getsize
    [PreserveSig]
    public D2D_SIZE_F GetSize();
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1rendertarget-getpixelsize
    [PreserveSig]
    public D2D_SIZE_U GetPixelSize();
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1rendertarget-getmaximumbitmapsize
    [PreserveSig]
    public uint GetMaximumBitmapSize();
    
    // https://learn.microsoft.com/windows/win32/api/d2d1/nf-d2d1-id2d1rendertarget-issupported(constd2d1_render_target_properties_)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    public bool IsSupported(in D2D1_RENDER_TARGET_PROPERTIES renderTargetProperties);
}
