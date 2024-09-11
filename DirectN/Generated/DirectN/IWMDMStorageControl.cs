#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mswmdm/nn-mswmdm-iwmdmstoragecontrol
[GeneratedComInterface, Guid("1dcb3a08-33ed-11d3-8470-00c04f79dbc0")]
public partial interface IWMDMStorageControl
{
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iwmdmstoragecontrol-insert
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Insert(uint fuMode, PWSTR pwszFile, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMDMOperation?>))] IWMDMOperation? pOperation, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMDMProgress?>))] IWMDMProgress? pProgress, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMDMStorage>))] out IWMDMStorage ppNewObject);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iwmdmstoragecontrol-delete
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Delete(uint fuMode, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMDMProgress?>))] IWMDMProgress? pProgress);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iwmdmstoragecontrol-rename
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Rename(uint fuMode, PWSTR pwszNewName, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMDMProgress?>))] IWMDMProgress? pProgress);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iwmdmstoragecontrol-read
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Read(uint fuMode, PWSTR pwszFile, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMDMProgress?>))] IWMDMProgress? pProgress, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMDMOperation?>))] IWMDMOperation? pOperation);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iwmdmstoragecontrol-move
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Move(uint fuMode, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMDMStorage?>))] IWMDMStorage? pTargetObject, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMDMProgress?>))] IWMDMProgress? pProgress);
}
