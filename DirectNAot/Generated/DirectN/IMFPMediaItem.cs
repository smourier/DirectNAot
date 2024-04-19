namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfplay/nn-mfplay-imfpmediaitem
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("90eb3e6b-ecbf-45cc-b1da-c6fe3ea70d57")]
public partial interface IMFPMediaItem
{
    // https://learn.microsoft.com/windows/win32/api/mfplay/nf-mfplay-imfpmediaitem-getmediaplayer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMediaPlayer(out IMFPMediaPlayer ppMediaPlayer);
    
    // https://learn.microsoft.com/windows/win32/api/mfplay/nf-mfplay-imfpmediaitem-geturl
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetURL(out PWSTR ppwszURL);
    
    // https://learn.microsoft.com/windows/win32/api/mfplay/nf-mfplay-imfpmediaitem-getobject
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetObject(out nint ppIUnknown);
    
    // https://learn.microsoft.com/windows/win32/api/mfplay/nf-mfplay-imfpmediaitem-getuserdata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetUserData(out nuint pdwUserData);
    
    // https://learn.microsoft.com/windows/win32/api/mfplay/nf-mfplay-imfpmediaitem-setuserdata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetUserData(nuint dwUserData);
    
    // https://learn.microsoft.com/windows/win32/api/mfplay/nf-mfplay-imfpmediaitem-getstartstopposition
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStartStopPosition(nint/* nint */ pguidStartPositionType, nint/* nint */ pvStartValue, nint/* nint */ pguidStopPositionType, nint/* nint */ pvStopValue);
    
    // https://learn.microsoft.com/windows/win32/api/mfplay/nf-mfplay-imfpmediaitem-setstartstopposition
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetStartStopPosition(nint/* nint */ pguidStartPositionType, nint/* nint */ pvStartValue, nint/* nint */ pguidStopPositionType, nint/* nint */ pvStopValue);
    
    // https://learn.microsoft.com/windows/win32/api/mfplay/nf-mfplay-imfpmediaitem-hasvideo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT HasVideo(nint/* nint */ pfHasVideo, nint/* nint */ pfSelected);
    
    // https://learn.microsoft.com/windows/win32/api/mfplay/nf-mfplay-imfpmediaitem-hasaudio
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT HasAudio(nint/* nint */ pfHasAudio, nint/* nint */ pfSelected);
    
    // https://learn.microsoft.com/windows/win32/api/mfplay/nf-mfplay-imfpmediaitem-isprotected
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsProtected([MarshalAs(UnmanagedType.U4)] out bool pfProtected);
    
    // https://learn.microsoft.com/windows/win32/api/mfplay/nf-mfplay-imfpmediaitem-getduration
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDuration(in Guid guidPositionType, out PROPVARIANT pvDurationValue);
    
    // https://learn.microsoft.com/windows/win32/api/mfplay/nf-mfplay-imfpmediaitem-getnumberofstreams
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetNumberOfStreams(out uint pdwStreamCount);
    
    // https://learn.microsoft.com/windows/win32/api/mfplay/nf-mfplay-imfpmediaitem-getstreamselection
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStreamSelection(uint dwStreamIndex, [MarshalAs(UnmanagedType.U4)] out bool pfEnabled);
    
    // https://learn.microsoft.com/windows/win32/api/mfplay/nf-mfplay-imfpmediaitem-setstreamselection
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetStreamSelection(uint dwStreamIndex, [MarshalAs(UnmanagedType.U4)] bool fEnabled);
    
    // https://learn.microsoft.com/windows/win32/api/mfplay/nf-mfplay-imfpmediaitem-getstreamattribute
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStreamAttribute(uint dwStreamIndex, in Guid guidMFAttribute, out PROPVARIANT pvValue);
    
    // https://learn.microsoft.com/windows/win32/api/mfplay/nf-mfplay-imfpmediaitem-getpresentationattribute
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPresentationAttribute(in Guid guidMFAttribute, out PROPVARIANT pvValue);
    
    // https://learn.microsoft.com/windows/win32/api/mfplay/nf-mfplay-imfpmediaitem-getcharacteristics
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCharacteristics(out uint pCharacteristics);
    
    // https://learn.microsoft.com/windows/win32/api/mfplay/nf-mfplay-imfpmediaitem-setstreamsink
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetStreamSink(uint dwStreamIndex, nint pMediaSink);
    
    // https://learn.microsoft.com/windows/win32/api/mfplay/nf-mfplay-imfpmediaitem-getmetadata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMetadata(out IPropertyStore ppMetadataStore);
}
