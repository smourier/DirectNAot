namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wincodec/nn-wincodec-iwiccomponentinfo
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("23bc3f0a-698b-4357-886b-f24d50671334")]
public partial interface IWICComponentInfo
{
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwiccomponentinfo-getcomponenttype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetComponentType(out WICComponentType pType);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwiccomponentinfo-getclsid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetCLSID(out Guid pclsid);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwiccomponentinfo-getsigningstatus
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetSigningStatus(out uint pStatus);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwiccomponentinfo-getauthor
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetAuthor(uint cchAuthor, ref PWSTR wzAuthor, out uint pcchActual);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwiccomponentinfo-getvendorguid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetVendorGUID(out Guid pguidVendor);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwiccomponentinfo-getversion
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetVersion(uint cchVersion, ref PWSTR wzVersion, out uint pcchActual);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwiccomponentinfo-getspecversion
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetSpecVersion(uint cchSpecVersion, ref PWSTR wzSpecVersion, out uint pcchActual);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwiccomponentinfo-getfriendlyname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetFriendlyName(uint cchFriendlyName, ref PWSTR wzFriendlyName, out uint pcchActual);
}
