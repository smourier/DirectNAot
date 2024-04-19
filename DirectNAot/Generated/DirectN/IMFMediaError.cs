namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfmediaengine/nn-mfmediaengine-imfmediaerror
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("fc0e10d2-ab2a-4501-a951-06bb1075184c")]
public partial interface IMFMediaError
{
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaerror-geterrorcode
    [PreserveSig]
    ushort GetErrorCode();
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaerror-getextendederrorcode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetExtendedErrorCode();
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaerror-seterrorcode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetErrorCode(MF_MEDIA_ENGINE_ERR error);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediaerror-setextendederrorcode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetExtendedErrorCode(HRESULT error);
}
