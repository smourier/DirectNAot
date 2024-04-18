namespace DirectN;

[GeneratedComInterface, Guid("a39ee748-6a27-4817-a6f2-13914bef5890")]
public partial interface IUri
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetPropertyBSTR(Uri_PROPERTY uriProp, out BSTR pbstrProperty, uint dwFlags);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetPropertyLength(Uri_PROPERTY uriProp, out uint pcchProperty, uint dwFlags);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetPropertyDWORD(Uri_PROPERTY uriProp, out uint pdwProperty, uint dwFlags);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT HasProperty(Uri_PROPERTY uriProp, [MarshalAs(UnmanagedType.U4)] out bool pfHasProperty);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetAbsoluteUri(out BSTR pbstrAbsoluteUri);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetAuthority(out BSTR pbstrAuthority);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetDisplayUri(out BSTR pbstrDisplayString);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetDomain(out BSTR pbstrDomain);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetExtension(out BSTR pbstrExtension);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetFragment(out BSTR pbstrFragment);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetHost(out BSTR pbstrHost);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetPassword(out BSTR pbstrPassword);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetPath(out BSTR pbstrPath);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetPathAndQuery(out BSTR pbstrPathAndQuery);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetQuery(out BSTR pbstrQuery);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetRawUri(out BSTR pbstrRawUri);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetSchemeName(out BSTR pbstrSchemeName);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetUserInfo(out BSTR pbstrUserInfo);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetUserName(out BSTR pbstrUserName);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetHostType(out uint pdwHostType);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetPort(out uint pdwPort);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetScheme(out uint pdwScheme);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetZone(out uint pdwZone);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetProperties(out uint pdwFlags);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT IsEqual(IUri pUri, [MarshalAs(UnmanagedType.U4)] out bool pfEqual);
}
