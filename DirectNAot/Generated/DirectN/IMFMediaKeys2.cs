namespace DirectN;

[GeneratedComInterface, Guid("45892507-ad66-4de2-83a2-acbb13cd8d43")]
public partial interface IMFMediaKeys2 : IMFMediaKeys
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateSession2(MF_MEDIAKEYSESSION_TYPE eSessionType, IMFMediaKeySessionNotify2 pMFMediaKeySessionNotify2, out IMFMediaKeySession2 ppSession);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetServerCertificate(nint /* byte array */ pbServerCertificate, uint cb);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDOMException(HRESULT systemCode, out HRESULT code);
}
