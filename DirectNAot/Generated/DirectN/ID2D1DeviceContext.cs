namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1_1/nn-d2d1_1-id2d1devicecontext
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("e8f7fe7a-191c-466d-ad95-975678bda998")]
public partial interface ID2D1DeviceContext : ID2D1RenderTarget
{
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1devicecontext-createbitmap(d2d1_size_u_constvoid_uint32_constd2d1_bitmap_properties1_id2d1bitmap1)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateBitmap(D2D_SIZE_U size, nint /* void */ sourceData, uint pitch, in D2D1_BITMAP_PROPERTIES1 bitmapProperties, out ID2D1Bitmap1 bitmap);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1devicecontext-createbitmapfromwicbitmap(iwicbitmapsource_id2d1bitmap1)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateBitmapFromWicBitmap(IWICBitmapSource wicBitmapSource, nint /* D2D1_BITMAP_PROPERTIES1 */ bitmapProperties, out ID2D1Bitmap1 bitmap);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1devicecontext-createcolorcontext
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateColorContext(D2D1_COLOR_SPACE space, nint /* byte array */ profile, uint profileSize, out ID2D1ColorContext colorContext);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1devicecontext-createcolorcontextfromfilename
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateColorContextFromFilename(PWSTR filename, out ID2D1ColorContext colorContext);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1devicecontext-createcolorcontextfromwiccolorcontext
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateColorContextFromWicColorContext(IWICColorContext wicColorContext, out ID2D1ColorContext colorContext);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1devicecontext-createbitmapfromdxgisurface(idxgisurface_constd2d1_bitmap_properties1_id2d1bitmap1)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateBitmapFromDxgiSurface(IDXGISurface surface, nint /* D2D1_BITMAP_PROPERTIES1 */ bitmapProperties, out ID2D1Bitmap1 bitmap);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1devicecontext-createeffect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateEffect(in Guid effectId, out ID2D1Effect effect);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1devicecontext-creategradientstopcollection
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateGradientStopCollection(in D2D1_GRADIENT_STOP straightAlphaGradientStops, uint straightAlphaGradientStopsCount, D2D1_COLOR_SPACE preInterpolationSpace, D2D1_COLOR_SPACE postInterpolationSpace, D2D1_BUFFER_PRECISION bufferPrecision, D2D1_EXTEND_MODE extendMode, D2D1_COLOR_INTERPOLATION_MODE colorInterpolationMode, out ID2D1GradientStopCollection1 gradientStopCollection1);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1devicecontext-createimagebrush(id2d1image_constd2d1_image_brush_properties__id2d1imagebrush)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateImageBrush(ID2D1Image image, in D2D1_IMAGE_BRUSH_PROPERTIES imageBrushProperties, nint /* D2D1_BRUSH_PROPERTIES */ brushProperties, out ID2D1ImageBrush imageBrush);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1devicecontext-createbitmapbrush(id2d1bitmap_constd2d1_bitmap_brush_properties1__constd2d1_brush_properties__id2d1bitmapbrush1)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateBitmapBrush(ID2D1Bitmap bitmap, nint /* D2D1_BITMAP_BRUSH_PROPERTIES1 */ bitmapBrushProperties, nint /* D2D1_BRUSH_PROPERTIES */ brushProperties, out ID2D1BitmapBrush1 bitmapBrush);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1devicecontext-createcommandlist
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateCommandList(out ID2D1CommandList commandList);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1devicecontext-isdxgiformatsupported
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    public bool IsDxgiFormatSupported(DXGI_FORMAT format);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1devicecontext-isbufferprecisionsupported
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    public bool IsBufferPrecisionSupported(D2D1_BUFFER_PRECISION bufferPrecision);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1devicecontext-getimagelocalbounds
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetImageLocalBounds(ID2D1Image image, out D2D_RECT_F localBounds);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1devicecontext-getimageworldbounds
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetImageWorldBounds(ID2D1Image image, out D2D_RECT_F worldBounds);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1devicecontext-getglyphrunworldbounds
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetGlyphRunWorldBounds(D2D_POINT_2F baselineOrigin, in DWRITE_GLYPH_RUN glyphRun, DWRITE_MEASURING_MODE measuringMode, out D2D_RECT_F bounds);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1devicecontext-getdevice
    [PreserveSig]
    public void GetDevice(out ID2D1Device device);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1devicecontext-settarget
    [PreserveSig]
    public void SetTarget(ID2D1Image image);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1devicecontext-gettarget
    [PreserveSig]
    public void GetTarget(out ID2D1Image image);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1devicecontext-setrenderingcontrols(constd2d1_rendering_controls_)
    [PreserveSig]
    public void SetRenderingControls(in D2D1_RENDERING_CONTROLS renderingControls);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1devicecontext-getrenderingcontrols
    [PreserveSig]
    public void GetRenderingControls(out D2D1_RENDERING_CONTROLS renderingControls);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1devicecontext-setprimitiveblend
    [PreserveSig]
    public void SetPrimitiveBlend(D2D1_PRIMITIVE_BLEND primitiveBlend);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1devicecontext-getprimitiveblend
    [PreserveSig]
    public D2D1_PRIMITIVE_BLEND GetPrimitiveBlend();
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1devicecontext-setunitmode
    [PreserveSig]
    public void SetUnitMode(D2D1_UNIT_MODE unitMode);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1devicecontext-getunitmode
    [PreserveSig]
    public D2D1_UNIT_MODE GetUnitMode();
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1devicecontext-drawglyphrun
    [PreserveSig]
    public void DrawGlyphRun(D2D_POINT_2F baselineOrigin, in DWRITE_GLYPH_RUN glyphRun, nint /* DWRITE_GLYPH_RUN_DESCRIPTION */ glyphRunDescription, ID2D1Brush foregroundBrush, DWRITE_MEASURING_MODE measuringMode);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1devicecontext-drawimage(id2d1image_constd2d1_point_2f_constd2d1_rect_f_d2d1_interpolation_mode_d2d1_composite_mode)
    [PreserveSig]
    public void DrawImage(ID2D1Image image, nint /* D2D_POINT_2F */ targetOffset, nint /* D2D_RECT_F */ imageRectangle, D2D1_INTERPOLATION_MODE interpolationMode, D2D1_COMPOSITE_MODE compositeMode);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1devicecontext-drawgdimetafile(id2d1gdimetafile_constd2d1_point_2f)
    [PreserveSig]
    public void DrawGdiMetafile(ID2D1GdiMetafile gdiMetafile, nint /* D2D_POINT_2F */ targetOffset);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1devicecontext-drawbitmap(id2d1bitmap_constd2d1_rect_f_float_d2d1_interpolation_mode_constd2d1_rect_f_constd2d1_matrix_4x4_f)
    [PreserveSig]
    public void DrawBitmap(ID2D1Bitmap bitmap, nint /* D2D_RECT_F */ destinationRectangle, float opacity, D2D1_INTERPOLATION_MODE interpolationMode, nint /* D2D_RECT_F */ sourceRectangle, nint /* D2D_MATRIX_4X4_F */ perspectiveTransform);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1devicecontext-pushlayer(constd2d1_layer_parameters1__id2d1layer)
    [PreserveSig]
    public void PushLayer(in D2D1_LAYER_PARAMETERS1 layerParameters, ID2D1Layer layer);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1devicecontext-invalidateeffectinputrectangle
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT InvalidateEffectInputRectangle(ID2D1Effect effect, uint input, in D2D_RECT_F inputRectangle);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1devicecontext-geteffectinvalidrectanglecount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetEffectInvalidRectangleCount(ID2D1Effect effect, out uint rectangleCount);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1devicecontext-geteffectinvalidrectangles
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetEffectInvalidRectangles(ID2D1Effect effect, out D2D_RECT_F rectangles, uint rectanglesCount);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1devicecontext-geteffectrequiredinputrectangles
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetEffectRequiredInputRectangles(ID2D1Effect renderEffect, nint /* D2D_RECT_F */ renderImageRectangle, in D2D1_EFFECT_INPUT_DESCRIPTION inputDescriptions, out D2D_RECT_F requiredInputRects, uint inputCount);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1devicecontext-fillopacitymask(id2d1bitmap_id2d1brush_constd2d1_rect_f__constd2d1_rect_f)
    [PreserveSig]
    public void FillOpacityMask(ID2D1Bitmap opacityMask, ID2D1Brush brush, nint /* D2D_RECT_F */ destinationRectangle, nint /* D2D_RECT_F */ sourceRectangle);
}
