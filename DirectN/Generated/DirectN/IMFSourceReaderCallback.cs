#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfreadwrite/nn-mfreadwrite-imfsourcereadercallback
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("deec8d99-fa1d-4d82-84c2-2c8969944867")]
public partial interface IMFSourceReaderCallback
{
    // https://learn.microsoft.com/windows/win32/api/mfreadwrite/nf-mfreadwrite-imfsourcereadercallback-onreadsample
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnReadSample(HRESULT hrStatus, uint dwStreamIndex, uint dwStreamFlags, long llTimestamp, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFSample?>))] IMFSample? pSample);
    
    // https://learn.microsoft.com/windows/win32/api/mfreadwrite/nf-mfreadwrite-imfsourcereadercallback-onflush
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnFlush(uint dwStreamIndex);
    
    // https://learn.microsoft.com/windows/win32/api/mfreadwrite/nf-mfreadwrite-imfsourcereadercallback-onevent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnEvent(uint dwStreamIndex, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaEvent>))] IMFMediaEvent pEvent);
}
