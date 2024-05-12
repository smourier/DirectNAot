#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1_3/nn-d2d1_3-id2d1devicecontext2
[SupportedOSPlatform("windows10.0.10240")]
[GeneratedComInterface, Guid("394ea6a3-0c34-4321-950b-6ca20f0be6c7")]
public partial interface ID2D1DeviceContext2 : ID2D1DeviceContext1
{
    // https://learn.microsoft.com/windows/win32/api/d2d1_3/nf-d2d1_3-id2d1devicecontext2-createink(constd2d1_ink_point__id2d1ink)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateInk(in D2D1_INK_POINT startPoint, out ID2D1Ink ink);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_3/nf-d2d1_3-id2d1devicecontext2-createinkstyle(constd2d1_ink_style_properties_id2d1inkstyle)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateInkStyle(nint /* optional D2D1_INK_STYLE_PROPERTIES* */ inkStyleProperties, out ID2D1InkStyle inkStyle);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_3/nf-d2d1_3-id2d1devicecontext2-creategradientmesh
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateGradientMesh([In][MarshalUsing(CountElementName = nameof(patchesCount))] D2D1_GRADIENT_MESH_PATCH[] patches, uint patchesCount, out ID2D1GradientMesh gradientMesh);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_3/nf-d2d1_3-id2d1devicecontext2-createimagesourcefromwic(iwicbitmapsource_d2d1_image_source_loading_options_id2d1imagesourcefromwic)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateImageSourceFromWic(IWICBitmapSource wicBitmapSource, D2D1_IMAGE_SOURCE_LOADING_OPTIONS loadingOptions, D2D1_ALPHA_MODE alphaMode, out ID2D1ImageSourceFromWic imageSource);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_3/nf-d2d1_3-id2d1devicecontext2-createlookuptable3d
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateLookupTable3D(D2D1_BUFFER_PRECISION precision, [MarshalUsing(ConstantElementCount = 3)] in uint[] extents, nint /* byte array */ data, uint dataCount, [MarshalUsing(ConstantElementCount = 2)] in uint[] strides, out ID2D1LookupTable3D lookupTable);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_3/nf-d2d1_3-id2d1devicecontext2-createimagesourcefromdxgi
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateImageSourceFromDxgi([In][MarshalUsing(CountElementName = nameof(surfaceCount))] IDXGISurface[] surfaces, uint surfaceCount, DXGI_COLOR_SPACE_TYPE colorSpace, D2D1_IMAGE_SOURCE_FROM_DXGI_OPTIONS options, out ID2D1ImageSource imageSource);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_3/nf-d2d1_3-id2d1devicecontext2-getgradientmeshworldbounds
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetGradientMeshWorldBounds(ID2D1GradientMesh gradientMesh, out D2D_RECT_F pBounds);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_3/nf-d2d1_3-id2d1devicecontext2-drawink
    [PreserveSig]
    void DrawInk(ID2D1Ink ink, ID2D1Brush brush, ID2D1InkStyle? inkStyle);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_3/nf-d2d1_3-id2d1devicecontext2-drawgradientmesh
    [PreserveSig]
    void DrawGradientMesh(ID2D1GradientMesh gradientMesh);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_3/nf-d2d1_3-id2d1devicecontext2-drawgdimetafile(id2d1gdimetafile_constd2d1_rect_f__constd2d1_rect_f_)
    [PreserveSig]
    void DrawGdiMetafile(ID2D1GdiMetafile gdiMetafile, nint /* optional D2D_RECT_F* */ destinationRectangle, nint /* optional D2D_RECT_F* */ sourceRectangle);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_3/nf-d2d1_3-id2d1devicecontext2-createtransformedimagesource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateTransformedImageSource(ID2D1ImageSource imageSource, in D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES properties, out ID2D1TransformedImageSource transformedImageSource);
}
