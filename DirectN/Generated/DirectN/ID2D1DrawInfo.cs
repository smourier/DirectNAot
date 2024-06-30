#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1effectauthor/nn-d2d1effectauthor-id2d1drawinfo
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("693ce632-7f2f-45de-93fe-18d88b37aa21")]
public partial interface ID2D1DrawInfo : ID2D1RenderInfo
{
    // https://learn.microsoft.com/windows/win32/api/d2d1effectauthor/nf-d2d1effectauthor-id2d1drawinfo-setpixelshaderconstantbuffer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPixelShaderConstantBuffer(nint /* byte array */ buffer, uint bufferCount);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1effectauthor/nf-d2d1effectauthor-id2d1drawinfo-setresourcetexture
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetResourceTexture(uint textureIndex, ID2D1ResourceTexture resourceTexture);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1effectauthor/nf-d2d1effectauthor-id2d1drawinfo-setvertexshaderconstantbuffer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetVertexShaderConstantBuffer(nint /* byte array */ buffer, uint bufferCount);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1effectauthor/nf-d2d1effectauthor-id2d1drawinfo-setpixelshader
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPixelShader(in Guid shaderId, D2D1_PIXEL_OPTIONS pixelOptions);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1effectauthor/nf-d2d1effectauthor-id2d1drawinfo-setvertexprocessing
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetVertexProcessing(ID2D1VertexBuffer? vertexBuffer, D2D1_VERTEX_OPTIONS vertexOptions, nint /* optional D2D1_BLEND_DESCRIPTION* */ blendDescription, nint /* optional D2D1_VERTEX_RANGE* */ vertexRange, nint /* optional Guid* */ vertexShader);
}
