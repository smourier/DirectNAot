#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mswmdm/nn-mswmdm-iwmdmstoragecontrol2
[GeneratedComInterface, Guid("972c2e88-bd6c-4125-8e09-84f837e637b6")]
public partial interface IWMDMStorageControl2 : IWMDMStorageControl
{
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iwmdmstoragecontrol2-insert2
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Insert2(uint fuMode, PWSTR pwszFileSource, PWSTR pwszFileDest, IWMDMOperation? pOperation, IWMDMProgress? pProgress, nint pUnknown, nint /* optional IWMDMStorage* */ ppNewObject);
}
