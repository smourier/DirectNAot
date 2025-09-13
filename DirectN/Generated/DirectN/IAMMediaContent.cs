#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/qnetwork/nn-qnetwork-iammediacontent
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("fa2aa8f4-8b62-11d0-a520-000000000000")]
public partial interface IAMMediaContent : IDispatch
{
    // https://learn.microsoft.com/windows/win32/api/qnetwork/nf-qnetwork-iammediacontent-get_authorname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_AuthorName(out BSTR pbstrAuthorName);
    
    // https://learn.microsoft.com/windows/win32/api/qnetwork/nf-qnetwork-iammediacontent-get_title
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Title(out BSTR pbstrTitle);
    
    // https://learn.microsoft.com/windows/win32/api/qnetwork/nf-qnetwork-iammediacontent-get_rating
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Rating(out BSTR pbstrRating);
    
    // https://learn.microsoft.com/windows/win32/api/qnetwork/nf-qnetwork-iammediacontent-get_description
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Description(out BSTR pbstrDescription);
    
    // https://learn.microsoft.com/windows/win32/api/qnetwork/nf-qnetwork-iammediacontent-get_copyright
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Copyright(out BSTR pbstrCopyright);
    
    // https://learn.microsoft.com/windows/win32/api/qnetwork/nf-qnetwork-iammediacontent-get_baseurl
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_BaseURL(out BSTR pbstrBaseURL);
    
    // https://learn.microsoft.com/windows/win32/api/qnetwork/nf-qnetwork-iammediacontent-get_logourl
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_LogoURL(out BSTR pbstrLogoURL);
    
    // https://learn.microsoft.com/windows/win32/api/qnetwork/nf-qnetwork-iammediacontent-get_logoiconurl
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_LogoIconURL(out BSTR pbstrLogoURL);
    
    // https://learn.microsoft.com/windows/win32/api/qnetwork/nf-qnetwork-iammediacontent-get_watermarkurl
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_WatermarkURL(out BSTR pbstrWatermarkURL);
    
    // https://learn.microsoft.com/windows/win32/api/qnetwork/nf-qnetwork-iammediacontent-get_moreinfourl
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_MoreInfoURL(out BSTR pbstrMoreInfoURL);
    
    // https://learn.microsoft.com/windows/win32/api/qnetwork/nf-qnetwork-iammediacontent-get_moreinfobannerimage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_MoreInfoBannerImage(out BSTR pbstrMoreInfoBannerImage);
    
    // https://learn.microsoft.com/windows/win32/api/qnetwork/nf-qnetwork-iammediacontent-get_moreinfobannerurl
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_MoreInfoBannerURL(out BSTR pbstrMoreInfoBannerURL);
    
    // https://learn.microsoft.com/windows/win32/api/qnetwork/nf-qnetwork-iammediacontent-get_moreinfotext
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_MoreInfoText(out BSTR pbstrMoreInfoText);
}
