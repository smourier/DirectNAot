namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfmetadata
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("f88cfb8c-ef16-4991-b450-cb8c69e51704")]
public partial interface IMFMetadata
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfmetadata-setlanguage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetLanguage(PWSTR pwszRFC1766);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfmetadata-getlanguage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLanguage(out PWSTR ppwszRFC1766);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfmetadata-getalllanguages
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAllLanguages(out PROPVARIANT ppvLanguages);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfmetadata-setproperty
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetProperty(PWSTR pwszName, in PROPVARIANT ppvValue);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfmetadata-getproperty
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetProperty(PWSTR pwszName, out PROPVARIANT ppvValue);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfmetadata-deleteproperty
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DeleteProperty(PWSTR pwszName);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfmetadata-getallpropertynames
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAllPropertyNames(out PROPVARIANT ppvNames);
}
