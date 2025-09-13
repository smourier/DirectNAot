#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/qnetwork/nn-qnetwork-iamchannelinfo
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("fa2aa8f2-8b62-11d0-a520-000000000000")]
public partial interface IAMChannelInfo : IDispatch
{
    // https://learn.microsoft.com/windows/win32/api/qnetwork/nf-qnetwork-iamchannelinfo-get_channelname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ChannelName(out BSTR pbstrChannelName);
    
    // https://learn.microsoft.com/windows/win32/api/qnetwork/nf-qnetwork-iamchannelinfo-get_channeldescription
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ChannelDescription(out BSTR pbstrChannelDescription);
    
    // https://learn.microsoft.com/windows/win32/api/qnetwork/nf-qnetwork-iamchannelinfo-get_channelurl
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ChannelURL(out BSTR pbstrChannelURL);
    
    // https://learn.microsoft.com/windows/win32/api/qnetwork/nf-qnetwork-iamchannelinfo-get_contactaddress
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ContactAddress(out BSTR pbstrContactAddress);
    
    // https://learn.microsoft.com/windows/win32/api/qnetwork/nf-qnetwork-iamchannelinfo-get_contactphone
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ContactPhone(out BSTR pbstrContactPhone);
    
    // https://learn.microsoft.com/windows/win32/api/qnetwork/nf-qnetwork-iamchannelinfo-get_contactemail
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ContactEmail(out BSTR pbstrContactEmail);
}
