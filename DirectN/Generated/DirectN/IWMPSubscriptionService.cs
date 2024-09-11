#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/subscriptionservices/nn-subscriptionservices-iwmpsubscriptionservice
[GeneratedComInterface, Guid("376055f8-2a59-4a73-9501-dca5273a7a10")]
public partial interface IWMPSubscriptionService
{
    // https://learn.microsoft.com/windows/win32/api/subscriptionservices/nf-subscriptionservices-iwmpsubscriptionservice-allowplay
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT allowPlay(HWND hwnd, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMPMedia>))] IWMPMedia pMedia, ref BOOL pfAllowPlay);
    
    // https://learn.microsoft.com/windows/win32/api/subscriptionservices/nf-subscriptionservices-iwmpsubscriptionservice-allowcdburn
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT allowCDBurn(HWND hwnd, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMPPlaylist>))] IWMPPlaylist pPlaylist, ref BOOL pfAllowBurn);
    
    // https://learn.microsoft.com/windows/win32/api/subscriptionservices/nf-subscriptionservices-iwmpsubscriptionservice-allowpdatransfer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT allowPDATransfer(HWND hwnd, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMPPlaylist>))] IWMPPlaylist pPlaylist, ref BOOL pfAllowTransfer);
    
    // https://learn.microsoft.com/windows/win32/api/subscriptionservices/nf-subscriptionservices-iwmpsubscriptionservice-startbackgroundprocessing
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT startBackgroundProcessing(HWND hwnd);
}
