namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/oaidl/nn-oaidl-itypelib
[GeneratedComInterface, Guid("00020402-0000-0000-c000-000000000046")]
public partial interface ITypeLib
{
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-itypelib-gettypeinfocount
    [PreserveSig]
    uint GetTypeInfoCount();
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-itypelib-gettypeinfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTypeInfo(uint index, out ITypeInfo ppTInfo);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-itypelib-gettypeinfotype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTypeInfoType(uint index, out TYPEKIND pTKind);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-itypelib-gettypeinfoofguid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTypeInfoOfGuid(in Guid guid, out ITypeInfo ppTinfo);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-itypelib-getlibattr
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLibAttr(out TLIBATTR ppTLibAttr);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-itypelib-gettypecomp
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTypeComp(out ITypeComp ppTComp);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-itypelib-getdocumentation
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDocumentation(int index, nint /* optional BSTR */ pBstrName, nint /* optional BSTR */ pBstrDocString, out uint pdwHelpContext, nint /* optional BSTR */ pBstrHelpFile);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-itypelib-isname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsName(ref PWSTR szNameBuf, uint lHashVal, [MarshalAs(UnmanagedType.U4)] out bool pfName);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-itypelib-findname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FindName(ref PWSTR szNameBuf, uint lHashVal, out ITypeInfo ppTInfo, out int rgMemId, ref ushort pcFound);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-itypelib-releasetlibattr
    [PreserveSig]
    void ReleaseTLibAttr(in TLIBATTR pTLibAttr);
}
