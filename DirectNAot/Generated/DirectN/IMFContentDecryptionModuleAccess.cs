namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfcontentdecryptionmodule/nn-mfcontentdecryptionmodule-imfcontentdecryptionmoduleaccess
[SupportedOSPlatform("windows10.0.19041")]
[GeneratedComInterface, Guid("a853d1f4-e2a0-4303-9edc-f1a68ee43136")]
public partial interface IMFContentDecryptionModuleAccess
{
    // https://learn.microsoft.com/windows/win32/api/mfcontentdecryptionmodule/nf-mfcontentdecryptionmodule-imfcontentdecryptionmoduleaccess-createcontentdecryptionmodule
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateContentDecryptionModule(IPropertyStore contentDecryptionModuleProperties, out IMFContentDecryptionModule contentDecryptionModule);
    
    // https://learn.microsoft.com/windows/win32/api/mfcontentdecryptionmodule/nf-mfcontentdecryptionmodule-imfcontentdecryptionmoduleaccess-getconfiguration
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetConfiguration(out IPropertyStore configuration);
    
    // https://learn.microsoft.com/windows/win32/api/mfcontentdecryptionmodule/nf-mfcontentdecryptionmodule-imfcontentdecryptionmoduleaccess-getkeysystem
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetKeySystem(out PWSTR keySystem);
}
