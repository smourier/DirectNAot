#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/nn-d3d12video-id3d12videoprocessor1
[GeneratedComInterface, Guid("f3cfe615-553f-425c-86d8-ee8c1b1fb01c")]
public partial interface ID3D12VideoProcessor1 : ID3D12VideoProcessor
{
    // https://learn.microsoft.com/windows/win32/api/d3d12video/nf-d3d12video-id3d12videoprocessor1-getprotectedresourcesession
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetProtectedResourceSession(in Guid riid, out nint /* void */ ppProtectedSession);
}
