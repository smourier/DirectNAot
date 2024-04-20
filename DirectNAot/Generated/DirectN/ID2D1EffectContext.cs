namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1effectauthor/nn-d2d1effectauthor-id2d1effectcontext
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("3d9f916b-27dc-4ad7-b4f1-64945340f563")]
public partial interface ID2D1EffectContext
{
    // https://learn.microsoft.com/windows/win32/api/d2d1effectauthor/nf-d2d1effectauthor-id2d1effectcontext-getdpi
    [PreserveSig]
    void GetDpi(out float dpiX, out float dpiY);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1effectauthor/nf-d2d1effectauthor-id2d1effectcontext-createeffect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateEffect(in Guid effectId, out ID2D1Effect effect);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1effectauthor/nf-d2d1effectauthor-id2d1effectcontext-getmaximumsupportedfeaturelevel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMaximumSupportedFeatureLevel(in D3D_FEATURE_LEVEL featureLevels, uint featureLevelsCount, out D3D_FEATURE_LEVEL maximumSupportedFeatureLevel);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1effectauthor/nf-d2d1effectauthor-id2d1effectcontext-createtransformnodefromeffect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateTransformNodeFromEffect(ID2D1Effect effect, out ID2D1TransformNode transformNode);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1effectauthor/nf-d2d1effectauthor-id2d1effectcontext-createblendtransform
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateBlendTransform(uint numInputs, in D2D1_BLEND_DESCRIPTION blendDescription, out ID2D1BlendTransform transform);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1effectauthor/nf-d2d1effectauthor-id2d1effectcontext-createbordertransform
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateBorderTransform(D2D1_EXTEND_MODE extendModeX, D2D1_EXTEND_MODE extendModeY, out ID2D1BorderTransform transform);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1effectauthor/nf-d2d1effectauthor-id2d1effectcontext-createoffsettransform
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateOffsetTransform(in FoundationPOINT offset, out ID2D1OffsetTransform transform);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1effectauthor/nf-d2d1effectauthor-id2d1effectcontext-createboundsadjustmenttransform
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateBoundsAdjustmentTransform(FoundationRECT outputRectangle, out ID2D1BoundsAdjustmentTransform transform);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1effectauthor/nf-d2d1effectauthor-id2d1effectcontext-loadpixelshader
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT LoadPixelShader(in Guid shaderId, nint /* byte array */ shaderBuffer, uint shaderBufferCount);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1effectauthor/nf-d2d1effectauthor-id2d1effectcontext-loadvertexshader
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT LoadVertexShader(in Guid resourceId, nint /* byte array */ shaderBuffer, uint shaderBufferCount);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1effectauthor/nf-d2d1effectauthor-id2d1effectcontext-loadcomputeshader
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT LoadComputeShader(in Guid resourceId, nint /* byte array */ shaderBuffer, uint shaderBufferCount);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1effectauthor/nf-d2d1effectauthor-id2d1effectcontext-isshaderloaded
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    bool IsShaderLoaded(in Guid shaderId);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1effectauthor/nf-d2d1effectauthor-id2d1effectcontext-createresourcetexture
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateResourceTexture(nint /* optional Guid */ resourceId, in D2D1_RESOURCE_TEXTURE_PROPERTIES resourceTextureProperties, nint /* byte array */ data, nint /* optional uint */ strides, uint dataSize, out ID2D1ResourceTexture resourceTexture);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1effectauthor/nf-d2d1effectauthor-id2d1effectcontext-findresourcetexture
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FindResourceTexture(in Guid resourceId, out ID2D1ResourceTexture resourceTexture);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1effectauthor/nf-d2d1effectauthor-id2d1effectcontext-createvertexbuffer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateVertexBuffer(in D2D1_VERTEX_BUFFER_PROPERTIES vertexBufferProperties, nint /* optional Guid */ resourceId, nint /* optional D2D1_CUSTOM_VERTEX_BUFFER_PROPERTIES */ customVertexBufferProperties, out ID2D1VertexBuffer buffer);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1effectauthor/nf-d2d1effectauthor-id2d1effectcontext-findvertexbuffer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FindVertexBuffer(in Guid resourceId, out ID2D1VertexBuffer buffer);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1effectauthor/nf-d2d1effectauthor-id2d1effectcontext-createcolorcontext
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateColorContext(D2D1_COLOR_SPACE space, nint /* byte array */ profile, uint profileSize, out ID2D1ColorContext colorContext);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1effectauthor/nf-d2d1effectauthor-id2d1effectcontext-createcolorcontextfromfilename
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateColorContextFromFilename(PWSTR filename, out ID2D1ColorContext colorContext);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1effectauthor/nf-d2d1effectauthor-id2d1effectcontext-createcolorcontextfromwiccolorcontext
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateColorContextFromWicColorContext(IWICColorContext wicColorContext, out ID2D1ColorContext colorContext);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1effectauthor/nf-d2d1effectauthor-id2d1effectcontext-checkfeaturesupport
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CheckFeatureSupport(D2D1_FEATURE feature, nint featureSupportData, uint featureSupportDataSize);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1effectauthor/nf-d2d1effectauthor-id2d1effectcontext-isbufferprecisionsupported
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    bool IsBufferPrecisionSupported(D2D1_BUFFER_PRECISION bufferPrecision);
}
