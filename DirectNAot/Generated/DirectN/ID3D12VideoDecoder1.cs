#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/nn-d3d12video-id3d12videodecoder1
[SupportedOSPlatform("windows10.0.19041")]
[GeneratedComInterface, Guid("79a2e5fb-ccd2-469a-9fde-195d10951f7e")]
public partial interface ID3D12VideoDecoder1 : ID3D12VideoDecoder
{
    // https://learn.microsoft.com/windows/win32/api/d3d12video/nf-d3d12video-id3d12videodecoder1-getprotectedresourcesession
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetProtectedResourceSession(in Guid riid, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<object>))] out object /* void */ ppProtectedSession);
}
