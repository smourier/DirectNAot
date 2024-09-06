#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mswmdm/nn-mswmdm-iscpsecureexchange
[GeneratedComInterface, Guid("1dcb3a0e-33ed-11d3-8470-00c04f79dbc0")]
public partial interface ISCPSecureExchange
{
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iscpsecureexchange-transfercontainerdata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TransferContainerData(nint /* byte array */ pData, uint dwSize, out uint pfuReadyFlags, nint /* byte array */ abMac);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iscpsecureexchange-objectdata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ObjectData(nint /* byte array */ pData, ref uint pdwSize, nint /* byte array */ abMac);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iscpsecureexchange-transfercomplete
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TransferComplete();
}
