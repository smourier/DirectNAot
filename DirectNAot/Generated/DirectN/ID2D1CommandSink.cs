namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1_1/nn-d2d1_1-id2d1commandsink
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("54d7898a-a061-40a7-bec7-e465bcba2c4f")]
public partial interface ID2D1CommandSink
{
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1commandsink-begindraw
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT BeginDraw();
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1commandsink-enddraw
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT EndDraw();
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1commandsink-setantialiasmode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetAntialiasMode(D2D1_ANTIALIAS_MODE antialiasMode);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1commandsink-settags
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetTags(ulong tag1, ulong tag2);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1commandsink-settextantialiasmode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetTextAntialiasMode(D2D1_TEXT_ANTIALIAS_MODE textAntialiasMode);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1commandsink-settextrenderingparams
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetTextRenderingParams(IDWriteRenderingParams textRenderingParams);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1commandsink-settransform
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetTransform(in D2D_MATRIX_3X2_F transform);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1commandsink-setprimitiveblend
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetPrimitiveBlend(D2D1_PRIMITIVE_BLEND primitiveBlend);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1commandsink-setunitmode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetUnitMode(D2D1_UNIT_MODE unitMode);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1commandsink-clear
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT Clear(nint/* nint */ color);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1commandsink-drawglyphrun
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT DrawGlyphRun(D2D_POINT_2F baselineOrigin, in DWRITE_GLYPH_RUN glyphRun, nint/* nint */ glyphRunDescription, ID2D1Brush foregroundBrush, DWRITE_MEASURING_MODE measuringMode);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1commandsink-drawline
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT DrawLine(D2D_POINT_2F point0, D2D_POINT_2F point1, ID2D1Brush brush, float strokeWidth, ID2D1StrokeStyle strokeStyle);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1commandsink-drawgeometry
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT DrawGeometry(ID2D1Geometry geometry, ID2D1Brush brush, float strokeWidth, ID2D1StrokeStyle strokeStyle);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1commandsink-drawrectangle
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT DrawRectangle(in D2D_RECT_F rect, ID2D1Brush brush, float strokeWidth, ID2D1StrokeStyle strokeStyle);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1commandsink-drawbitmap
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT DrawBitmap(ID2D1Bitmap bitmap, nint/* nint */ destinationRectangle, float opacity, D2D1_INTERPOLATION_MODE interpolationMode, nint/* nint */ sourceRectangle, nint/* nint */ perspectiveTransform);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1commandsink-drawimage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT DrawImage(ID2D1Image image, nint/* nint */ targetOffset, nint/* nint */ imageRectangle, D2D1_INTERPOLATION_MODE interpolationMode, D2D1_COMPOSITE_MODE compositeMode);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1commandsink-drawgdimetafile
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT DrawGdiMetafile(ID2D1GdiMetafile gdiMetafile, nint/* nint */ targetOffset);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1commandsink-fillmesh
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT FillMesh(ID2D1Mesh mesh, ID2D1Brush brush);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1commandsink-fillopacitymask
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT FillOpacityMask(ID2D1Bitmap opacityMask, ID2D1Brush brush, nint/* nint */ destinationRectangle, nint/* nint */ sourceRectangle);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1commandsink-fillgeometry
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT FillGeometry(ID2D1Geometry geometry, ID2D1Brush brush, ID2D1Brush opacityBrush);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1commandsink-fillrectangle
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT FillRectangle(in D2D_RECT_F rect, ID2D1Brush brush);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1commandsink-pushaxisalignedclip
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT PushAxisAlignedClip(in D2D_RECT_F clipRect, D2D1_ANTIALIAS_MODE antialiasMode);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1commandsink-pushlayer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT PushLayer(in D2D1_LAYER_PARAMETERS1 layerParameters1, ID2D1Layer layer);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1commandsink-popaxisalignedclip
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT PopAxisAlignedClip();
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1commandsink-poplayer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT PopLayer();
}
