#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mswmdm/nn-mswmdm-iwmdmmetadata
[GeneratedComInterface, Guid("ec3b0663-0951-460a-9a80-0dceed3c043c")]
public partial interface IWMDMMetaData
{
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iwmdmmetadata-additem
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddItem(WMDM_TAG_DATATYPE Type, PWSTR pwszTagName, nint /* optional byte* */ pValue, uint iLength);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iwmdmmetadata-querybyname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT QueryByName(PWSTR pwszTagName, out WMDM_TAG_DATATYPE pType, out nint /* byte array */ pValue, out uint pcbLength);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iwmdmmetadata-querybyindex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT QueryByIndex(uint iIndex, out nint ppwszName, out WMDM_TAG_DATATYPE pType, out nint /* byte array */ ppValue, out uint pcbLength);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iwmdmmetadata-getitemcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetItemCount(out uint iCount);
}
