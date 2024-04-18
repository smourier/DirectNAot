namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/directmanipulation/nn-directmanipulation-idirectmanipulationdefercontactservice
[SupportedOSPlatform("windows10.0.10240")]
[GeneratedComInterface, Guid("652d5c71-fe60-4a98-be70-e5f21291e7f1")]
public partial interface IDirectManipulationDeferContactService
{
    // https://learn.microsoft.com/windows/win32/api/directmanipulation/nf-directmanipulation-idirectmanipulationdefercontactservice-defercontact
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT DeferContact(uint pointerId, uint timeout);
    
    // https://learn.microsoft.com/windows/win32/api/directmanipulation/nf-directmanipulation-idirectmanipulationdefercontactservice-cancelcontact
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CancelContact(uint pointerId);
    
    // https://learn.microsoft.com/windows/win32/api/directmanipulation/nf-directmanipulation-idirectmanipulationdefercontactservice-canceldeferral
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CancelDeferral(uint pointerId);
}
