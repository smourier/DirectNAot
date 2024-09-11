#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mswmdm/nn-mswmdm-imdspdirecttransfer
[GeneratedComInterface, Guid("c2fe57a8-9304-478c-9ee4-47e397b912d7")]
public partial interface IMDSPDirectTransfer
{
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-imdspdirecttransfer-transfertodevice
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TransferToDevice(PWSTR pwszSourceFilePath, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMDMOperation?>))] IWMDMOperation? pSourceOperation, uint fuFlags, PWSTR pwszDestinationName, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMDMMetaData?>))] IWMDMMetaData? pSourceMetaData, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMDMProgress?>))] IWMDMProgress? pTransferProgress, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMDSPStorage>))] out IMDSPStorage ppNewObject);
}
