#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-iamdevmemorycontrol
[GeneratedComInterface, Guid("c6545bf1-e76b-11d0-bd52-00a0c911ce86")]
public partial interface IAMDevMemoryControl
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamdevmemorycontrol-querywritesync
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT QueryWriteSync();
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamdevmemorycontrol-writesync
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT WriteSync();
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamdevmemorycontrol-getdevid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDevId(out uint pdwDevId);
}
