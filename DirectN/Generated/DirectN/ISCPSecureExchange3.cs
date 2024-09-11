#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mswmdm/nn-mswmdm-iscpsecureexchange3
[GeneratedComInterface, Guid("ab4e77e4-8908-4b17-bd2a-b1dbe6dd69e1")]
public partial interface ISCPSecureExchange3 : ISCPSecureExchange2
{
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iscpsecureexchange3-transfercontainerdataonclearchannel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TransferContainerDataOnClearChannel([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMDSPDevice?>))] IMDSPDevice? pDevice, nint /* byte array */ pData, uint dwSize, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMDMProgress3?>))] IWMDMProgress3? pProgressCallback, out uint pfuReadyFlags);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetObjectDataOnClearChannel([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMDSPDevice?>))] IMDSPDevice? pDevice, nint /* byte array */ pData, ref uint pdwSize);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iscpsecureexchange3-transfercompletefordevice
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TransferCompleteForDevice([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMDSPDevice?>))] IMDSPDevice? pDevice);
}
