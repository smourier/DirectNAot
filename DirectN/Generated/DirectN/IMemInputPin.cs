#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-imeminputpin
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("56a8689d-0ad4-11ce-b03a-0020af0ba770")]
public partial interface IMemInputPin
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-imeminputpin-getallocator
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAllocator([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMemAllocator>))] out IMemAllocator ppAllocator);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-imeminputpin-notifyallocator
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT NotifyAllocator([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMemAllocator>))] IMemAllocator pAllocator, BOOL bReadOnly);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-imeminputpin-getallocatorrequirements
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAllocatorRequirements(out ALLOCATOR_PROPERTIES pProps);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-imeminputpin-receive
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Receive([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMediaSample>))] IMediaSample pSample);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-imeminputpin-receivemultiple
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ReceiveMultiple([In][MarshalUsing(CountElementName = nameof(nSamples))] IMediaSample[] pSamples, int nSamples, out int nSamplesProcessed);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-imeminputpin-receivecanblock
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ReceiveCanBlock();
}
