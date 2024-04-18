namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1effectauthor/nn-d2d1effectauthor-id2d1computeinfo
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("5598b14b-9fd7-48b7-9bdb-8f0964eb38bc")]
public partial interface ID2D1ComputeInfo : ID2D1RenderInfo
{
    // https://learn.microsoft.com/windows/win32/api/d2d1effectauthor/nf-d2d1effectauthor-id2d1computeinfo-setcomputeshaderconstantbuffer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetComputeShaderConstantBuffer(nint /* byte array */ buffer, uint bufferCount);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1effectauthor/nf-d2d1effectauthor-id2d1computeinfo-setcomputeshader
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetComputeShader(in Guid shaderId);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1effectauthor/nf-d2d1effectauthor-id2d1computeinfo-setresourcetexture
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetResourceTexture(uint textureIndex, ID2D1ResourceTexture resourceTexture);
}
