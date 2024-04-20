namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1_1/nn-d2d1_1-id2d1factory1
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("bb12d362-daee-4b9a-aa1d-14ba401cfa1f")]
public partial interface ID2D1Factory1 : ID2D1Factory
{
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1factory1-createdevice
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateDevice(IDXGIDevice dxgiDevice, out ID2D1Device d2dDevice);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1factory1-createstrokestyle(constd2d1_stroke_style_properties1_constfloat_uint32_id2d1strokestyle1)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateStrokeStyle(in D2D1_STROKE_STYLE_PROPERTIES1 strokeStyleProperties, nint /* optional float */ dashes, uint dashesCount, out ID2D1StrokeStyle1 strokeStyle);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1factory1-createpathgeometry
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreatePathGeometry(out ID2D1PathGeometry1 pathGeometry);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1factory1-createdrawingstateblock(constd2d1_drawing_state_description1_idwriterenderingparams_id2d1drawingstateblock1)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateDrawingStateBlock(nint /* optional D2D1_DRAWING_STATE_DESCRIPTION1 */ drawingStateDescription, IDWriteRenderingParams textRenderingParams, out ID2D1DrawingStateBlock1 drawingStateBlock);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1factory1-creategdimetafile
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateGdiMetafile(IStream metafileStream, out ID2D1GdiMetafile metafile);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1factory1-registereffectfromstream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RegisterEffectFromStream(in Guid classId, IStream propertyXml, nint /* optional D2D1_PROPERTY_BINDING */ bindings, uint bindingsCount, PD2D1_EFFECT_FACTORY effectFactory);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1factory1-registereffectfromstring
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RegisterEffectFromString(in Guid classId, PWSTR propertyXml, nint /* optional D2D1_PROPERTY_BINDING */ bindings, uint bindingsCount, PD2D1_EFFECT_FACTORY effectFactory);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1factory1-unregistereffect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UnregisterEffect(in Guid classId);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1factory1-getregisteredeffects
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRegisteredEffects(nint /* optional Guid */ effects, uint effectsCount, nint /* optional uint */ effectsReturned, nint /* optional uint */ effectsRegistered);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1factory1-geteffectproperties
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetEffectProperties(in Guid effectId, out ID2D1Properties properties);
}
