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
    HRESULT get_AuthorName(ref BSTR pbstrAuthorName);
    
    // https://learn.microsoft.com/windows/win32/api/qnetwork/nf-qnetwork-iammediacontent-get_title
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Title(ref BSTR pbstrTitle);
    
    // https://learn.microsoft.com/windows/win32/api/qnetwork/nf-qnetwork-iammediacontent-get_rating
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Rating(ref BSTR pbstrRating);
    
    // https://learn.microsoft.com/windows/win32/api/qnetwork/nf-qnetwork-iammediacontent-get_description
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Description(ref BSTR pbstrDescription);
    
    // https://learn.microsoft.com/windows/win32/api/qnetwork/nf-qnetwork-iammediacontent-get_copyright
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Copyright(ref BSTR pbstrCopyright);
    
    // https://learn.microsoft.com/windows/win32/api/qnetwork/nf-qnetwork-iammediacontent-get_baseurl
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_BaseURL(ref BSTR pbstrBaseURL);
    
    // https://learn.microsoft.com/windows/win32/api/qnetwork/nf-qnetwork-iammediacontent-get_logourl
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_LogoURL(ref BSTR pbstrLogoURL);
    
    // https://learn.microsoft.com/windows/win32/api/qnetwork/nf-qnetwork-iammediacontent-get_logoiconurl
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_LogoIconURL(ref BSTR pbstrLogoURL);
    
    // https://learn.microsoft.com/windows/win32/api/qnetwork/nf-qnetwork-iammediacontent-get_watermarkurl
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_WatermarkURL(ref BSTR pbstrWatermarkURL);
    
    // https://learn.microsoft.com/windows/win32/api/qnetwork/nf-qnetwork-iammediacontent-get_moreinfourl
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_MoreInfoURL(ref BSTR pbstrMoreInfoURL);
    
    // https://learn.microsoft.com/windows/win32/api/qnetwork/nf-qnetwork-iammediacontent-get_moreinfobannerimage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_MoreInfoBannerImage(ref BSTR pbstrMoreInfoBannerImage);
    
    // https://learn.microsoft.com/windows/win32/api/qnetwork/nf-qnetwork-iammediacontent-get_moreinfobannerurl
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_MoreInfoBannerURL(ref BSTR pbstrMoreInfoBannerURL);
    
    // https://learn.microsoft.com/windows/win32/api/qnetwork/nf-qnetwork-iammediacontent-get_moreinfotext
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_MoreInfoText(ref BSTR pbstrMoreInfoText);
}
