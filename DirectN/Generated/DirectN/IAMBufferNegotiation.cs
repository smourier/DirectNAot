#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-iambuffernegotiation
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("56ed71a0-af5f-11d0-b3f0-00aa003761c5")]
public partial interface IAMBufferNegotiation
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iambuffernegotiation-suggestallocatorproperties
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SuggestAllocatorProperties(in ALLOCATOR_PROPERTIES pprop);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iambuffernegotiation-getallocatorproperties
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAllocatorProperties(out ALLOCATOR_PROPERTIES pprop);
}
