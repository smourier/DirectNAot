#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-iamdevmemoryallocator
[GeneratedComInterface, Guid("c6545bf0-e76b-11d0-bd52-00a0c911ce86")]
public partial interface IAMDevMemoryAllocator
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamdevmemoryallocator-getinfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetInfo(out uint pdwcbTotalFree, out uint pdwcbLargestFree, out uint pdwcbTotalMemory, out uint pdwcbMinimumChunk);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamdevmemoryallocator-checkmemory
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CheckMemory(nint /* byte array */ pBuffer);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamdevmemoryallocator-alloc
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Alloc(out nint /* byte array */ ppBuffer, ref uint pdwcbBuffer);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamdevmemoryallocator-free
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Free(nint /* byte array */ pBuffer);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamdevmemoryallocator-getdevmemoryobject
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDevMemoryObject([MarshalUsing(typeof(UniqueComInterfaceMarshaller<nint>))] out nint ppUnkInnner, nint pUnkOuter);
}
