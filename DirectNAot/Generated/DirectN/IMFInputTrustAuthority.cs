namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfinputtrustauthority
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("d19f8e98-b126-4446-890c-5dcb7ad71453")]
public partial interface IMFInputTrustAuthority
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfinputtrustauthority-getdecrypter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDecrypter(in Guid riid, out nint ppv);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfinputtrustauthority-requestaccess
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RequestAccess(MFPOLICYMANAGER_ACTION Action, out IMFActivate ppContentEnablerActivate);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfinputtrustauthority-getpolicy
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPolicy(MFPOLICYMANAGER_ACTION Action, out IMFOutputPolicy ppPolicy);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfinputtrustauthority-bindaccess
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT BindAccess(in MFINPUTTRUSTAUTHORITY_ACCESS_PARAMS pParam);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfinputtrustauthority-updateaccess
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UpdateAccess(in MFINPUTTRUSTAUTHORITY_ACCESS_PARAMS pParam);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfinputtrustauthority-reset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Reset();
}
