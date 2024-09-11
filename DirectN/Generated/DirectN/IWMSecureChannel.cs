#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsecure/nn-wmsecure-iwmsecurechannel
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("2720598a-d0f2-4189-bd10-91c46ef0936f")]
public partial interface IWMSecureChannel : IWMAuthorizer
{
    // https://learn.microsoft.com/windows/win32/api/wmsecure/nf-wmsecure-iwmsecurechannel-wmsc_addcertificate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT WMSC_AddCertificate([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMAuthorizer>))] IWMAuthorizer pCert);
    
    // https://learn.microsoft.com/windows/win32/api/wmsecure/nf-wmsecure-iwmsecurechannel-wmsc_addsignature
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT WMSC_AddSignature(nint /* byte array */ pbCertSig, uint cbCertSig);
    
    // https://learn.microsoft.com/windows/win32/api/wmsecure/nf-wmsecure-iwmsecurechannel-wmsc_connect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT WMSC_Connect([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMSecureChannel>))] IWMSecureChannel pOtherSide);
    
    // https://learn.microsoft.com/windows/win32/api/wmsecure/nf-wmsecure-iwmsecurechannel-wmsc_isconnected
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT WMSC_IsConnected(out BOOL pfIsConnected);
    
    // https://learn.microsoft.com/windows/win32/api/wmsecure/nf-wmsecure-iwmsecurechannel-wmsc_disconnect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT WMSC_Disconnect();
    
    // https://learn.microsoft.com/windows/win32/api/wmsecure/nf-wmsecure-iwmsecurechannel-wmsc_getvalidcertificate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT WMSC_GetValidCertificate(out nint /* byte array */ ppbCertificate, out uint pdwSignature);
    
    // https://learn.microsoft.com/windows/win32/api/wmsecure/nf-wmsecure-iwmsecurechannel-wmsc_encrypt
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT WMSC_Encrypt(nint /* byte array */ pbData, uint cbData);
    
    // https://learn.microsoft.com/windows/win32/api/wmsecure/nf-wmsecure-iwmsecurechannel-wmsc_decrypt
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT WMSC_Decrypt(nint /* byte array */ pbData, uint cbData);
    
    // https://learn.microsoft.com/windows/win32/api/wmsecure/nf-wmsecure-iwmsecurechannel-wmsc_lock
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT WMSC_Lock();
    
    // https://learn.microsoft.com/windows/win32/api/wmsecure/nf-wmsecure-iwmsecurechannel-wmsc_unlock
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT WMSC_Unlock();
    
    // https://learn.microsoft.com/windows/win32/api/wmsecure/nf-wmsecure-iwmsecurechannel-wmsc_setshareddata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT WMSC_SetSharedData(uint dwCertIndex, nint /* byte array */ pbSharedData);
}
