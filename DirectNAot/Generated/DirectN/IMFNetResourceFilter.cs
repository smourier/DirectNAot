namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfnetresourcefilter
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("091878a3-bf11-4a5c-bc9f-33995b06ef2d")]
public partial interface IMFNetResourceFilter
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfnetresourcefilter-onredirect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnRedirect(PWSTR pszUrl, out VARIANT_BOOL pvbCancel);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfnetresourcefilter-onsendingrequest
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnSendingRequest(PWSTR pszUrl);
}
