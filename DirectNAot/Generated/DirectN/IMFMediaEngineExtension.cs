namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfmediaengine/nn-mfmediaengine-imfmediaengineextension
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("2f69d622-20b5-41e9-afdf-89ced1dda04e")]
public partial interface IMFMediaEngineExtension
{
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaengineextension-canplaytype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CanPlayType([MarshalAs(UnmanagedType.U4)] bool AudioOnly, BSTR MimeType, out MF_MEDIA_ENGINE_CANPLAY pAnswer);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaengineextension-begincreateobject
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT BeginCreateObject(BSTR bstrURL, IMFByteStream pByteStream, MF_OBJECT_TYPE type, out nint ppIUnknownCancelCookie, IMFAsyncCallback pCallback, nint punkState);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaengineextension-cancelobjectcreation
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CancelObjectCreation(nint pIUnknownCancelCookie);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaengineextension-endcreateobject
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EndCreateObject(IMFAsyncResult pResult, out nint ppObject);
}
