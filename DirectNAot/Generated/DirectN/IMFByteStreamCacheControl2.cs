#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfbytestreamcachecontrol2
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("71ce469c-f34b-49ea-a56b-2d2a10e51149")]
public partial interface IMFByteStreamCacheControl2 : IMFByteStreamCacheControl
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfbytestreamcachecontrol2-getbyteranges
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetByteRanges(out uint pcRanges, [MarshalUsing(CountElementName = nameof(pcRanges))] out MF_BYTE_STREAM_CACHE_RANGE[] ppRanges);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfbytestreamcachecontrol2-setcachelimit
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetCacheLimit(ulong qwBytes);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfbytestreamcachecontrol2-isbackgroundtransferactive
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsBackgroundTransferActive([MarshalAs(UnmanagedType.U4)] out bool pfActive);
}
