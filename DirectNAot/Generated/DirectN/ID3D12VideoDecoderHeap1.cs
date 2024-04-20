namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/nn-d3d12video-id3d12videodecoderheap1
[GeneratedComInterface, Guid("da1d98c5-539f-41b2-bf6b-1198a03b6d26")]
public partial interface ID3D12VideoDecoderHeap1 : ID3D12VideoDecoderHeap
{
    // https://learn.microsoft.com/windows/win32/api/d3d12video/nf-d3d12video-id3d12videodecoderheap1-getprotectedresourcesession
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetProtectedResourceSession(in Guid riid, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<object>))] out object /* void */ ppProtectedSession);
}
