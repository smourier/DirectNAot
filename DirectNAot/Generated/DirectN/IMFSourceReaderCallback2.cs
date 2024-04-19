namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfreadwrite/nn-mfreadwrite-imfsourcereadercallback2
[GeneratedComInterface, Guid("cf839fe6-8c2a-4dd2-b6ea-c22d6961af05")]
public partial interface IMFSourceReaderCallback2 : IMFSourceReaderCallback
{
    // https://learn.microsoft.com/windows/win32/api/mfreadwrite/nf-mfreadwrite-imfsourcereadercallback2-ontransformchange
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnTransformChange();
    
    // https://learn.microsoft.com/windows/win32/api/mfreadwrite/nf-mfreadwrite-imfsourcereadercallback2-onstreamerror
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnStreamError(uint dwStreamIndex, HRESULT hrStatus);
}
