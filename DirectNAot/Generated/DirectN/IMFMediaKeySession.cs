namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfmediaengine/nn-mfmediaengine-imfmediakeysession
[SupportedOSPlatform("windows8.1")]
[GeneratedComInterface, Guid("24fa67d5-d1d0-4dc5-995c-c0efdc191fb5")]
public partial interface IMFMediaKeySession
{
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediakeysession-geterror
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetError(out ushort code, out uint systemCode);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediakeysession-get_keysystem
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_KeySystem(out BSTR keySystem);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediakeysession-get_sessionid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_SessionId(out BSTR sessionId);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediakeysession-update
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Update(nint /* byte array */ key, uint cb);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediakeysession-close
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Close();
}
