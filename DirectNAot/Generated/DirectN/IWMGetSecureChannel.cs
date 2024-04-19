namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsecure/nn-wmsecure-iwmgetsecurechannel
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("94bc0598-c3d2-11d3-bedf-00c04f612986")]
public partial interface IWMGetSecureChannel
{
    // https://learn.microsoft.com/windows/win32/api/wmsecure/nf-wmsecure-iwmgetsecurechannel-getpeersecurechannelinterface
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPeerSecureChannelInterface(out IWMSecureChannel ppPeer);
}
