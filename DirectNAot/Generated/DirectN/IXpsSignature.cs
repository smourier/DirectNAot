#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xpsdigitalsignature/nn-xpsdigitalsignature-ixpssignature
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("6ae4c93e-1ade-42fb-898b-3a5658284857")]
public partial interface IXpsSignature
{
    // https://learn.microsoft.com/windows/win32/api/xpsdigitalsignature/nf-xpsdigitalsignature-ixpssignature-getsignatureid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSignatureId(out PWSTR sigId);
    
    // https://learn.microsoft.com/windows/win32/api/xpsdigitalsignature/nf-xpsdigitalsignature-ixpssignature-getsignaturevalue
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSignatureValue(out nint /* byte array */ signatureHashValue, out uint count);
    
    // https://learn.microsoft.com/windows/win32/api/xpsdigitalsignature/nf-xpsdigitalsignature-ixpssignature-getcertificateenumerator
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCertificateEnumerator(out IOpcCertificateEnumerator certificateEnumerator);
    
    // https://learn.microsoft.com/windows/win32/api/xpsdigitalsignature/nf-xpsdigitalsignature-ixpssignature-getsigningtime
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSigningTime(out PWSTR sigDateTimeString);
    
    // https://learn.microsoft.com/windows/win32/api/xpsdigitalsignature/nf-xpsdigitalsignature-ixpssignature-getsigningtimeformat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSigningTimeFormat(out OPC_SIGNATURE_TIME_FORMAT timeFormat);
    
    // https://learn.microsoft.com/windows/win32/api/xpsdigitalsignature/nf-xpsdigitalsignature-ixpssignature-getsignaturepartname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSignaturePartName(out IOpcPartUri signaturePartName);
    
    // https://learn.microsoft.com/windows/win32/api/xpsdigitalsignature/nf-xpsdigitalsignature-ixpssignature-verify
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Verify(in CERT_CONTEXT x509Certificate, out XPS_SIGNATURE_STATUS sigStatus);
    
    // https://learn.microsoft.com/windows/win32/api/xpsdigitalsignature/nf-xpsdigitalsignature-ixpssignature-getpolicy
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPolicy(out XPS_SIGN_POLICY policy);
    
    // https://learn.microsoft.com/windows/win32/api/xpsdigitalsignature/nf-xpsdigitalsignature-ixpssignature-getcustomobjectenumerator
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCustomObjectEnumerator(out IOpcSignatureCustomObjectEnumerator customObjectEnumerator);
    
    // https://learn.microsoft.com/windows/win32/api/xpsdigitalsignature/nf-xpsdigitalsignature-ixpssignature-getcustomreferenceenumerator
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCustomReferenceEnumerator(out IOpcSignatureReferenceEnumerator customReferenceEnumerator);
    
    // https://learn.microsoft.com/windows/win32/api/xpsdigitalsignature/nf-xpsdigitalsignature-ixpssignature-getsignaturexml
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSignatureXml(out nint /* byte array */ signatureXml, out uint count);
    
    // https://learn.microsoft.com/windows/win32/api/xpsdigitalsignature/nf-xpsdigitalsignature-ixpssignature-setsignaturexml
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSignatureXml(nint /* byte array */ signatureXml, uint count);
}
