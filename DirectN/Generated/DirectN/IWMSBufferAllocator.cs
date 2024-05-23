#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsbuffer/nn-wmsbuffer-iwmsbufferallocator
[GeneratedComInterface, Guid("61103ca4-2033-11d2-9ef1-006097d2d7cf")]
public partial interface IWMSBufferAllocator
{
    // https://learn.microsoft.com/windows/win32/api/wmsbuffer/nf-wmsbuffer-iwmsbufferallocator-allocatebuffer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AllocateBuffer(uint dwMaxBufferSize, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<INSSBuffer>))] out INSSBuffer ppBuffer);
    
    // https://learn.microsoft.com/windows/win32/api/wmsbuffer/nf-wmsbuffer-iwmsbufferallocator-allocatepagesizebuffer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AllocatePageSizeBuffer(uint dwMaxBufferSize, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<INSSBuffer>))] out INSSBuffer ppBuffer);
}
