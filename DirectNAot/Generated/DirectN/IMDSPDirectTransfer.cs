namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mswmdm/nn-mswmdm-imdspdirecttransfer
[GeneratedComInterface, Guid("c2fe57a8-9304-478c-9ee4-47e397b912d7")]
public partial interface IMDSPDirectTransfer
{
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-imdspdirecttransfer-transfertodevice
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TransferToDevice(PWSTR? pwszSourceFilePath, IWMDMOperation? pSourceOperation, uint fuFlags, PWSTR? pwszDestinationName, IWMDMMetaData? pSourceMetaData, IWMDMProgress? pTransferProgress, out IMDSPStorage ppNewObject);
}
