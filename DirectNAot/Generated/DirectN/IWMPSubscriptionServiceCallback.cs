namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/subscriptionservices/nn-subscriptionservices-iwmpsubscriptionservicecallback
[GeneratedComInterface, Guid("dd01d127-2dc2-4c3a-876e-63312079f9b0")]
public partial interface IWMPSubscriptionServiceCallback
{
    // https://learn.microsoft.com/windows/win32/api/subscriptionservices/nf-subscriptionservices-iwmpsubscriptionservicecallback-oncomplete
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT onComplete(HRESULT hrResult);
}
