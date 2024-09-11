#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/subscriptionservices/nn-subscriptionservices-iwmpsubscriptionservice2
[GeneratedComInterface, Guid("a94c120e-d600-4ec6-b05e-ec9d56d84de0")]
public partial interface IWMPSubscriptionService2 : IWMPSubscriptionService
{
    // https://learn.microsoft.com/windows/win32/api/subscriptionservices/nf-subscriptionservices-iwmpsubscriptionservice2-stopbackgroundprocessing
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT stopBackgroundProcessing();
    
    // https://learn.microsoft.com/windows/win32/api/subscriptionservices/nf-subscriptionservices-iwmpsubscriptionservice2-serviceevent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT serviceEvent(WMPSubscriptionServiceEvent @event);
    
    // https://learn.microsoft.com/windows/win32/api/subscriptionservices/nf-subscriptionservices-iwmpsubscriptionservice2-deviceavailable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT deviceAvailable(BSTR bstrDeviceName, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMPSubscriptionServiceCallback>))] IWMPSubscriptionServiceCallback pCB);
    
    // https://learn.microsoft.com/windows/win32/api/subscriptionservices/nf-subscriptionservices-iwmpsubscriptionservice2-prepareforsync
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT prepareForSync(BSTR bstrFilename, BSTR bstrDeviceName, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMPSubscriptionServiceCallback>))] IWMPSubscriptionServiceCallback pCB);
}
