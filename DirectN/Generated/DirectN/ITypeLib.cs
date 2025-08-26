#nullable enable
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
    HRESULT GetTypeInfo(uint index, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITypeInfo>))] out ITypeInfo ppTInfo);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-itypelib-gettypeinfotype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTypeInfoType(uint index, out TYPEKIND pTKind);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-itypelib-gettypeinfoofguid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTypeInfoOfGuid(in Guid guid, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITypeInfo>))] out ITypeInfo ppTinfo);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-itypelib-getlibattr
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLibAttr(out nint ppTLibAttr);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-itypelib-gettypecomp
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTypeComp([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITypeComp>))] out ITypeComp ppTComp);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-itypelib-getdocumentation
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDocumentation(int index, nint /* optional BSTR* */ pBstrName, nint /* optional BSTR* */ pBstrDocString, out uint pdwHelpContext, nint /* optional BSTR* */ pBstrHelpFile);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-itypelib-isname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsName(PWSTR szNameBuf, uint lHashVal, out BOOL pfName);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-itypelib-findname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FindName(PWSTR szNameBuf, uint lHashVal, [MarshalUsing(CountElementName = nameof(pcFound))] out nint[] ppTInfo, [MarshalUsing(CountElementName = nameof(pcFound))] out int[] rgMemId, ref ushort pcFound);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-itypelib-releasetlibattr
    [PreserveSig]
    void ReleaseTLibAttr(nint pTLibAttr);
}
