#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xpsdigitalsignature/nn-xpsdigitalsignature-ixpssignaturerequest
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("ac58950b-7208-4b2d-b2c4-951083d3b8eb")]
public partial interface IXpsSignatureRequest
{
    // https://learn.microsoft.com/windows/win32/api/xpsdigitalsignature/nf-xpsdigitalsignature-ixpssignaturerequest-getintent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetIntent(out PWSTR intent);
    
    // https://learn.microsoft.com/windows/win32/api/xpsdigitalsignature/nf-xpsdigitalsignature-ixpssignaturerequest-setintent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetIntent(PWSTR intent);
    
    // https://learn.microsoft.com/windows/win32/api/xpsdigitalsignature/nf-xpsdigitalsignature-ixpssignaturerequest-getrequestedsigner
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRequestedSigner(out PWSTR signerName);
    
    // https://learn.microsoft.com/windows/win32/api/xpsdigitalsignature/nf-xpsdigitalsignature-ixpssignaturerequest-setrequestedsigner
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetRequestedSigner(PWSTR signerName);
    
    // https://learn.microsoft.com/windows/win32/api/xpsdigitalsignature/nf-xpsdigitalsignature-ixpssignaturerequest-getrequestsignbydate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRequestSignByDate(out PWSTR dateString);
    
    // https://learn.microsoft.com/windows/win32/api/xpsdigitalsignature/nf-xpsdigitalsignature-ixpssignaturerequest-setrequestsignbydate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetRequestSignByDate(PWSTR dateString);
    
    // https://learn.microsoft.com/windows/win32/api/xpsdigitalsignature/nf-xpsdigitalsignature-ixpssignaturerequest-getsigninglocale
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSigningLocale(out PWSTR place);
    
    // https://learn.microsoft.com/windows/win32/api/xpsdigitalsignature/nf-xpsdigitalsignature-ixpssignaturerequest-setsigninglocale
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSigningLocale(PWSTR place);
    
    // https://learn.microsoft.com/windows/win32/api/xpsdigitalsignature/nf-xpsdigitalsignature-ixpssignaturerequest-getspotlocation
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSpotLocation(out int pageIndex, out IOpcPartUri pagePartName, out float x, out float y);
    
    // https://learn.microsoft.com/windows/win32/api/xpsdigitalsignature/nf-xpsdigitalsignature-ixpssignaturerequest-setspotlocation
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSpotLocation(int pageIndex, float x, float y);
    
    // https://learn.microsoft.com/windows/win32/api/xpsdigitalsignature/nf-xpsdigitalsignature-ixpssignaturerequest-getrequestid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRequestId(out PWSTR requestId);
    
    // https://learn.microsoft.com/windows/win32/api/xpsdigitalsignature/nf-xpsdigitalsignature-ixpssignaturerequest-getsignature
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSignature(out IXpsSignature signature);
}
