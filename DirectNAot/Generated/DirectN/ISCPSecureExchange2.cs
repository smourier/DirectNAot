namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mswmdm/nn-mswmdm-iscpsecureexchange2
[GeneratedComInterface, Guid("6c62fc7b-2690-483f-9d44-0a20cb35577c")]
public partial interface ISCPSecureExchange2 : ISCPSecureExchange
{
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iscpsecureexchange2-transfercontainerdata2
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TransferContainerData2(nint /* byte array */ pData, uint dwSize, IWMDMProgress3 pProgressCallback, out uint pfuReadyFlags, nint /* byte array */ abMac);
}
