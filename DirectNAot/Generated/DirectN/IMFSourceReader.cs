namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfreadwrite/nn-mfreadwrite-imfsourcereader
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("70ae66f2-c809-4e4f-8915-bdcb406b7993")]
public partial interface IMFSourceReader
{
    // https://learn.microsoft.com/windows/win32/api/mfreadwrite/nf-mfreadwrite-imfsourcereader-getstreamselection
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStreamSelection(uint dwStreamIndex, [MarshalAs(UnmanagedType.U4)] out bool pfSelected);
    
    // https://learn.microsoft.com/windows/win32/api/mfreadwrite/nf-mfreadwrite-imfsourcereader-setstreamselection
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetStreamSelection(uint dwStreamIndex, [MarshalAs(UnmanagedType.U4)] bool fSelected);
    
    // https://learn.microsoft.com/windows/win32/api/mfreadwrite/nf-mfreadwrite-imfsourcereader-getnativemediatype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetNativeMediaType(uint dwStreamIndex, uint dwMediaTypeIndex, out IMFMediaType ppMediaType);
    
    // https://learn.microsoft.com/windows/win32/api/mfreadwrite/nf-mfreadwrite-imfsourcereader-getcurrentmediatype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCurrentMediaType(uint dwStreamIndex, out IMFMediaType ppMediaType);
    
    // https://learn.microsoft.com/windows/win32/api/mfreadwrite/nf-mfreadwrite-imfsourcereader-setcurrentmediatype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetCurrentMediaType(uint dwStreamIndex, nint /* optional uint */ pdwReserved, IMFMediaType pMediaType);
    
    // https://learn.microsoft.com/windows/win32/api/mfreadwrite/nf-mfreadwrite-imfsourcereader-setcurrentposition
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetCurrentPosition(in Guid guidTimeFormat, in PROPVARIANT varPosition);
    
    // https://learn.microsoft.com/windows/win32/api/mfreadwrite/nf-mfreadwrite-imfsourcereader-readsample
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ReadSample(uint dwStreamIndex, uint dwControlFlags, nint /* optional uint */ pdwActualStreamIndex, nint /* optional uint */ pdwStreamFlags, nint /* optional long */ pllTimestamp, nint /* optional IMFSample */ ppSample);
    
    // https://learn.microsoft.com/windows/win32/api/mfreadwrite/nf-mfreadwrite-imfsourcereader-flush
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Flush(uint dwStreamIndex);
    
    // https://learn.microsoft.com/windows/win32/api/mfreadwrite/nf-mfreadwrite-imfsourcereader-getserviceforstream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetServiceForStream(uint dwStreamIndex, in Guid guidService, in Guid riid, out nint ppvObject);
    
    // https://learn.microsoft.com/windows/win32/api/mfreadwrite/nf-mfreadwrite-imfsourcereader-getpresentationattribute
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPresentationAttribute(uint dwStreamIndex, in Guid guidAttribute, out PROPVARIANT pvarAttribute);
}
