namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xpsdigitalsignature/nn-xpsdigitalsignature-ixpssignaturemanager
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("d3e8d338-fdc4-4afc-80b5-d532a1782ee1")]
public partial interface IXpsSignatureManager
{
    // https://learn.microsoft.com/windows/win32/api/xpsdigitalsignature/nf-xpsdigitalsignature-ixpssignaturemanager-loadpackagefile
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT LoadPackageFile(PWSTR fileName);
    
    // https://learn.microsoft.com/windows/win32/api/xpsdigitalsignature/nf-xpsdigitalsignature-ixpssignaturemanager-loadpackagestream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT LoadPackageStream(IStream stream);
    
    // https://learn.microsoft.com/windows/win32/api/xpsdigitalsignature/nf-xpsdigitalsignature-ixpssignaturemanager-sign
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Sign(IXpsSigningOptions signOptions, in CERT_CONTEXT x509Certificate, out IXpsSignature signature);
    
    // https://learn.microsoft.com/windows/win32/api/xpsdigitalsignature/nf-xpsdigitalsignature-ixpssignaturemanager-getsignatureoriginpartname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSignatureOriginPartName(out IOpcPartUri signatureOriginPartName);
    
    // https://learn.microsoft.com/windows/win32/api/xpsdigitalsignature/nf-xpsdigitalsignature-ixpssignaturemanager-setsignatureoriginpartname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSignatureOriginPartName(IOpcPartUri signatureOriginPartName);
    
    // https://learn.microsoft.com/windows/win32/api/xpsdigitalsignature/nf-xpsdigitalsignature-ixpssignaturemanager-getsignatures
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSignatures(out IXpsSignatureCollection signatures);
    
    // https://learn.microsoft.com/windows/win32/api/xpsdigitalsignature/nf-xpsdigitalsignature-ixpssignaturemanager-addsignatureblock
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddSignatureBlock(IOpcPartUri partName, uint fixedDocumentIndex, out IXpsSignatureBlock signatureBlock);
    
    // https://learn.microsoft.com/windows/win32/api/xpsdigitalsignature/nf-xpsdigitalsignature-ixpssignaturemanager-getsignatureblocks
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSignatureBlocks(out IXpsSignatureBlockCollection signatureBlocks);
    
    // https://learn.microsoft.com/windows/win32/api/xpsdigitalsignature/nf-xpsdigitalsignature-ixpssignaturemanager-createsigningoptions
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateSigningOptions(out IXpsSigningOptions signingOptions);
    
    // https://learn.microsoft.com/windows/win32/api/xpsdigitalsignature/nf-xpsdigitalsignature-ixpssignaturemanager-savepackagetofile
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SavePackageToFile(PWSTR fileName, in SECURITY_ATTRIBUTES securityAttributes, uint flagsAndAttributes);
    
    // https://learn.microsoft.com/windows/win32/api/xpsdigitalsignature/nf-xpsdigitalsignature-ixpssignaturemanager-savepackagetostream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SavePackageToStream(IStream stream);
}
