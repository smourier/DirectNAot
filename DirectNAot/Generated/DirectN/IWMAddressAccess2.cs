namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/nn-wmsdkidl-iwmaddressaccess2
[GeneratedComInterface, Guid("65a83fc2-3e98-4d4d-81b5-2a742886b33d")]
public partial interface IWMAddressAccess2 : IWMAddressAccess
{
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmaddressaccess2-getaccessentryex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAccessEntryEx(WM_AETYPE aeType, uint dwEntryNum, out BSTR pbstrAddress, out BSTR pbstrMask);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmaddressaccess2-addaccessentryex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddAccessEntryEx(WM_AETYPE aeType, BSTR bstrAddress, BSTR bstrMask);
}
