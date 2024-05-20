#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfcontentdecryptionmodule/nn-mfcontentdecryptionmodule-imfcontentdecryptionmodule
[SupportedOSPlatform("windows10.0.19041")]
[GeneratedComInterface, Guid("87be986c-10be-4943-bf48-4b54ce1983a2")]
public partial interface IMFContentDecryptionModule
{
    // https://learn.microsoft.com/windows/win32/api/mfcontentdecryptionmodule/nf-mfcontentdecryptionmodule-imfcontentdecryptionmodule-setcontentenabler
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetContentEnabler(IMFContentEnabler contentEnabler, IMFAsyncResult result);
    
    // https://learn.microsoft.com/windows/win32/api/mfcontentdecryptionmodule/nf-mfcontentdecryptionmodule-imfcontentdecryptionmodule-getsuspendnotify
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSuspendNotify(out IMFCdmSuspendNotify notify);
    
    // https://learn.microsoft.com/windows/win32/api/mfcontentdecryptionmodule/nf-mfcontentdecryptionmodule-imfcontentdecryptionmodule-setpmphostapp
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPMPHostApp(IMFPMPHostApp pmpHostApp);
    
    // https://learn.microsoft.com/windows/win32/api/mfcontentdecryptionmodule/nf-mfcontentdecryptionmodule-imfcontentdecryptionmodule-createsession
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateSession(MF_MEDIAKEYSESSION_TYPE sessionType, IMFContentDecryptionModuleSessionCallbacks callbacks, out IMFContentDecryptionModuleSession session);
    
    // https://learn.microsoft.com/windows/win32/api/mfcontentdecryptionmodule/nf-mfcontentdecryptionmodule-imfcontentdecryptionmodule-setservercertificate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetServerCertificate(nint /* byte array */ certificate, uint certificateSize);
    
    // https://learn.microsoft.com/windows/win32/api/mfcontentdecryptionmodule/nf-mfcontentdecryptionmodule-imfcontentdecryptionmodule-createtrustedinput
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateTrustedInput(nint /* byte array */ contentInitData, uint contentInitDataSize, out IMFTrustedInput trustedInput);
    
    // https://learn.microsoft.com/windows/win32/api/mfcontentdecryptionmodule/nf-mfcontentdecryptionmodule-imfcontentdecryptionmodule-getprotectionsystemids
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetProtectionSystemIds([MarshalUsing(CountElementName = nameof(count))] out Guid[] systemIds, out uint count);
}
