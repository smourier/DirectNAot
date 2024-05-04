#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/nn-wmsdkidl-iwmaddressaccess
[GeneratedComInterface, Guid("bb3c6389-1633-4e92-af14-9f3173ba39d0")]
public partial interface IWMAddressAccess
{
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmaddressaccess-getaccessentrycount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAccessEntryCount(WM_AETYPE aeType, out uint pcEntries);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmaddressaccess-getaccessentry
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAccessEntry(WM_AETYPE aeType, uint dwEntryNum, out WM_ADDRESS_ACCESSENTRY pAddrAccessEntry);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmaddressaccess-addaccessentry
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddAccessEntry(WM_AETYPE aeType, in WM_ADDRESS_ACCESSENTRY pAddrAccessEntry);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmaddressaccess-removeaccessentry
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveAccessEntry(WM_AETYPE aeType, uint dwEntryNum);
}
