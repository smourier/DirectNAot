#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("a39ee748-6a27-4817-a6f2-13914bef5890")]
public partial interface IUri
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPropertyBSTR(Uri_PROPERTY uriProp, out BSTR pbstrProperty, uint dwFlags);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPropertyLength(Uri_PROPERTY uriProp, out uint pcchProperty, uint dwFlags);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPropertyDWORD(Uri_PROPERTY uriProp, out uint pdwProperty, uint dwFlags);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT HasProperty(Uri_PROPERTY uriProp, out BOOL pfHasProperty);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAbsoluteUri(out BSTR pbstrAbsoluteUri);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAuthority(out BSTR pbstrAuthority);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDisplayUri(out BSTR pbstrDisplayString);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDomain(out BSTR pbstrDomain);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetExtension(out BSTR pbstrExtension);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFragment(out BSTR pbstrFragment);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetHost(out BSTR pbstrHost);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPassword(out BSTR pbstrPassword);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPath(out BSTR pbstrPath);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPathAndQuery(out BSTR pbstrPathAndQuery);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetQuery(out BSTR pbstrQuery);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRawUri(out BSTR pbstrRawUri);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSchemeName(out BSTR pbstrSchemeName);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetUserInfo(out BSTR pbstrUserInfo);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetUserName(out BSTR pbstrUserName);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetHostType(out uint pdwHostType);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPort(out uint pdwPort);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetScheme(out uint pdwScheme);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetZone(out uint pdwZone);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetProperties(out uint pdwFlags);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsEqual([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IUri>))] IUri pUri, out BOOL pfEqual);
}
