#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("14056581-e16c-11d2-bb90-00c04f8ee6c0")]
public partial interface ISpDataKey
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetData(PWSTR pszValueName, uint cbData, nint /* byte array */ pData);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetData(PWSTR pszValueName, ref uint pcbData, nint /* byte array */ pData);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetStringValue(PWSTR pszValueName, PWSTR pszValue);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStringValue(PWSTR pszValueName, out PWSTR ppszValue);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDWORD(PWSTR pszValueName, uint dwValue);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDWORD(PWSTR pszValueName, ref uint pdwValue);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OpenKey(PWSTR pszSubKeyName, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISpDataKey>))] out ISpDataKey ppSubKey);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateKey(PWSTR pszSubKey, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISpDataKey>))] out ISpDataKey ppSubKey);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DeleteKey(PWSTR pszSubKey);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DeleteValue(PWSTR pszValueName);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumKeys(uint Index, out PWSTR ppszSubKeyName);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumValues(uint Index, out PWSTR ppszValueName);
}
