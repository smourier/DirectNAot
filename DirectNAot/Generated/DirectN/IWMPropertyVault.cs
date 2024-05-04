#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/nn-wmsdkidl-iwmpropertyvault
[GeneratedComInterface, Guid("72995a79-5090-42a4-9c8c-d9d0b6d34be5")]
public partial interface IWMPropertyVault
{
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmpropertyvault-getpropertycount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPropertyCount(in uint pdwCount);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmpropertyvault-getpropertybyname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPropertyByName(PWSTR pszName, out WMT_ATTR_DATATYPE pType, nint /* byte array */ pValue, ref uint pdwSize);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmpropertyvault-setproperty
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetProperty(PWSTR pszName, WMT_ATTR_DATATYPE pType, nint /* byte array */ pValue, uint dwSize);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmpropertyvault-getpropertybyindex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPropertyByIndex(uint dwIndex, [MarshalUsing(CountElementName = nameof(pdwNameLen))] out PWSTR[] pszName, ref uint pdwNameLen, out WMT_ATTR_DATATYPE pType, nint /* byte array */ pValue, ref uint pdwSize);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmpropertyvault-copypropertiesfrom
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CopyPropertiesFrom(IWMPropertyVault pIWMPropertyVault);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmpropertyvault-clear
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Clear();
}
