#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mswmdm/nn-mswmdm-iwmdmstoragecontrol3
[GeneratedComInterface, Guid("b3266365-d4f3-4696-8d53-bd27ec60993a")]
public partial interface IWMDMStorageControl3 : IWMDMStorageControl2
{
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iwmdmstoragecontrol3-insert3
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Insert3(uint fuMode, uint fuType, PWSTR pwszFileSource, PWSTR pwszFileDest, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMDMOperation?>))] IWMDMOperation? pOperation, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMDMProgress?>))] IWMDMProgress? pProgress, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMDMMetaData?>))] IWMDMMetaData? pMetaData, nint pUnknown, nint /* optional IWMDMStorage* */ ppNewObject);
}
