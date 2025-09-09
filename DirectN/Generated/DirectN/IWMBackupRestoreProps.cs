#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/nn-wmsdkidl-iwmbackuprestoreprops
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("3c8e0da6-996f-4ff3-a1af-4838f9377e2e")]
public partial interface IWMBackupRestoreProps
{
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmbackuprestoreprops-getpropcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPropCount(out ushort pcProps);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmbackuprestoreprops-getpropbyindex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPropByIndex(ushort wIndex, [MarshalUsing(CountElementName = nameof(pcchNameLen))] PWSTR pwszName, ref ushort pcchNameLen, out WMT_ATTR_DATATYPE pType, nint /* byte array */ pValue, ref ushort pcbLength);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmbackuprestoreprops-getpropbyname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPropByName(PWSTR pszName, out WMT_ATTR_DATATYPE pType, nint /* byte array */ pValue, ref ushort pcbLength);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmbackuprestoreprops-setprop
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetProp(PWSTR pszName, WMT_ATTR_DATATYPE Type, nint /* byte array */ pValue, ushort cbLength);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmbackuprestoreprops-removeprop
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveProp(PWSTR pcwszName);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmbackuprestoreprops-removeallprops
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveAllProps();
}
