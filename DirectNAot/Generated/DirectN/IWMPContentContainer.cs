namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/contentpartner/nn-contentpartner-iwmpcontentcontainer
[GeneratedComInterface, Guid("ad7f4d9c-1a9f-4ed2-9815-ecc0b58cb616")]
public partial interface IWMPContentContainer
{
    // https://learn.microsoft.com/windows/win32/api/contentpartner/nf-contentpartner-iwmpcontentcontainer-getid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetID(out uint pContentID);
    
    // https://learn.microsoft.com/windows/win32/api/contentpartner/nf-contentpartner-iwmpcontentcontainer-getprice
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPrice(out BSTR pbstrPrice);
    
    // https://learn.microsoft.com/windows/win32/api/contentpartner/nf-contentpartner-iwmpcontentcontainer-gettype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetType(out BSTR pbstrType);
    
    // https://learn.microsoft.com/windows/win32/api/contentpartner/nf-contentpartner-iwmpcontentcontainer-getcontentcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetContentCount(out uint pcContent);
    
    // https://learn.microsoft.com/windows/win32/api/contentpartner/nf-contentpartner-iwmpcontentcontainer-getcontentprice
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetContentPrice(uint idxContent, out BSTR pbstrPrice);
    
    // https://learn.microsoft.com/windows/win32/api/contentpartner/nf-contentpartner-iwmpcontentcontainer-getcontentid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetContentID(uint idxContent, out uint pContentID);
}
