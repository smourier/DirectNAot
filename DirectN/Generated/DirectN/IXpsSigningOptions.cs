#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xpsdigitalsignature/nn-xpsdigitalsignature-ixpssigningoptions
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("7718eae4-3215-49be-af5b-594fef7fcfa6")]
public partial interface IXpsSigningOptions
{
    // https://learn.microsoft.com/windows/win32/api/xpsdigitalsignature/nf-xpsdigitalsignature-ixpssigningoptions-getsignatureid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSignatureId(out PWSTR signatureId);
    
    // https://learn.microsoft.com/windows/win32/api/xpsdigitalsignature/nf-xpsdigitalsignature-ixpssigningoptions-setsignatureid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSignatureId(PWSTR signatureId);
    
    // https://learn.microsoft.com/windows/win32/api/xpsdigitalsignature/nf-xpsdigitalsignature-ixpssigningoptions-getsignaturemethod
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSignatureMethod(out PWSTR signatureMethod);
    
    // https://learn.microsoft.com/windows/win32/api/xpsdigitalsignature/nf-xpsdigitalsignature-ixpssigningoptions-setsignaturemethod
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSignatureMethod(PWSTR signatureMethod);
    
    // https://learn.microsoft.com/windows/win32/api/xpsdigitalsignature/nf-xpsdigitalsignature-ixpssigningoptions-getdigestmethod
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDigestMethod(out PWSTR digestMethod);
    
    // https://learn.microsoft.com/windows/win32/api/xpsdigitalsignature/nf-xpsdigitalsignature-ixpssigningoptions-setdigestmethod
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDigestMethod(PWSTR digestMethod);
    
    // https://learn.microsoft.com/windows/win32/api/xpsdigitalsignature/nf-xpsdigitalsignature-ixpssigningoptions-getsignaturepartname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSignaturePartName([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IOpcPartUri>))] out IOpcPartUri signaturePartName);
    
    // https://learn.microsoft.com/windows/win32/api/xpsdigitalsignature/nf-xpsdigitalsignature-ixpssigningoptions-setsignaturepartname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSignaturePartName(IOpcPartUri signaturePartName);
    
    // https://learn.microsoft.com/windows/win32/api/xpsdigitalsignature/nf-xpsdigitalsignature-ixpssigningoptions-getpolicy
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPolicy(out XPS_SIGN_POLICY policy);
    
    // https://learn.microsoft.com/windows/win32/api/xpsdigitalsignature/nf-xpsdigitalsignature-ixpssigningoptions-setpolicy
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPolicy(XPS_SIGN_POLICY policy);
    
    // https://learn.microsoft.com/windows/win32/api/xpsdigitalsignature/nf-xpsdigitalsignature-ixpssigningoptions-getsigningtimeformat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSigningTimeFormat(out OPC_SIGNATURE_TIME_FORMAT timeFormat);
    
    // https://learn.microsoft.com/windows/win32/api/xpsdigitalsignature/nf-xpsdigitalsignature-ixpssigningoptions-setsigningtimeformat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSigningTimeFormat(OPC_SIGNATURE_TIME_FORMAT timeFormat);
    
    // https://learn.microsoft.com/windows/win32/api/xpsdigitalsignature/nf-xpsdigitalsignature-ixpssigningoptions-getcustomobjects
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCustomObjects([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IOpcSignatureCustomObjectSet>))] out IOpcSignatureCustomObjectSet customObjectSet);
    
    // https://learn.microsoft.com/windows/win32/api/xpsdigitalsignature/nf-xpsdigitalsignature-ixpssigningoptions-getcustomreferences
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCustomReferences([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IOpcSignatureReferenceSet>))] out IOpcSignatureReferenceSet customReferenceSet);
    
    // https://learn.microsoft.com/windows/win32/api/xpsdigitalsignature/nf-xpsdigitalsignature-ixpssigningoptions-getcertificateset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCertificateSet([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IOpcCertificateSet>))] out IOpcCertificateSet certificateSet);
    
    // https://learn.microsoft.com/windows/win32/api/xpsdigitalsignature/nf-xpsdigitalsignature-ixpssigningoptions-getflags
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFlags(out XPS_SIGN_FLAGS flags);
    
    // https://learn.microsoft.com/windows/win32/api/xpsdigitalsignature/nf-xpsdigitalsignature-ixpssigningoptions-setflags
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFlags(XPS_SIGN_FLAGS flags);
}
