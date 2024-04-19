namespace DirectN;

[GeneratedComInterface, Guid("79eac9ee-baf9-11ce-8c82-00aa004ba90b")]
public partial interface IInternetSecurityManager
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSecuritySite(IInternetSecurityMgrSite pSite);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSecuritySite(out IInternetSecurityMgrSite ppSite);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT MapUrlToZone(PWSTR pwszUrl, out uint pdwZone, uint dwFlags);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSecurityId(PWSTR pwszUrl, nint /* byte array */ pbSecurityId, ref uint pcbSecurityId, nuint dwReserved);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ProcessUrlAction(PWSTR pwszUrl, uint dwAction, nint /* byte array */ pPolicy, uint cbPolicy, nint /* byte array */ pContext, uint cbContext, uint dwFlags, uint dwReserved);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT QueryCustomPolicy(PWSTR pwszUrl, in Guid guidKey, out nint /* byte array */ ppPolicy, out uint pcbPolicy, nint /* byte array */ pContext, uint cbContext, uint dwReserved);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetZoneMapping(uint dwZone, PWSTR lpszPattern, uint dwFlags);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetZoneMappings(uint dwZone, out IEnumString ppenumString, uint dwFlags);
}
