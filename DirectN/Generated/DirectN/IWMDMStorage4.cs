#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mswmdm/nn-mswmdm-iwmdmstorage4
[GeneratedComInterface, Guid("c225bac5-a03a-40b8-9a23-91cf478c64a6")]
public partial interface IWMDMStorage4 : IWMDMStorage3
{
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iwmdmstorage4-setreferences
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetReferences(uint dwRefs, nint /* optional IWMDMStorage* */ ppIWMDMStorage);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iwmdmstorage4-getreferences
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetReferences(out uint pdwRefs, out nint pppIWMDMStorage);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iwmdmstorage4-getrightswithprogress
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRightsWithProgress([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMDMProgress3?>))] IWMDMProgress3? pIProgressCallback, out nint ppRights, out uint pnRightsCount);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iwmdmstorage4-getspecifiedmetadata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSpecifiedMetadata(uint cProperties, [In][MarshalUsing(CountElementName = nameof(cProperties))] PWSTR[] ppwszPropNames, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMDMMetaData>))] out IWMDMMetaData ppMetadata);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iwmdmstorage4-findstorage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FindStorage(WMDM_FIND_SCOPE findScope, PWSTR pwszUniqueID, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMDMStorage>))] out IWMDMStorage ppStorage);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iwmdmstorage4-getparent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetParent([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMDMStorage>))] out IWMDMStorage ppStorage);
}
