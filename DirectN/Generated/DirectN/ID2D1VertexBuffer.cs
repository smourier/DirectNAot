#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1effectauthor/nn-d2d1effectauthor-id2d1vertexbuffer
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("9b8b1336-00a5-4668-92b7-ced5d8bf9b7b")]
public partial interface ID2D1VertexBuffer
{
    // https://learn.microsoft.com/windows/win32/api/d2d1effectauthor/nf-d2d1effectauthor-id2d1vertexbuffer-map
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Map(out nint /* byte array */ data, uint bufferSize);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1effectauthor/nf-d2d1effectauthor-id2d1vertexbuffer-unmap
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Unmap();
}
