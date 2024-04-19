namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/oaidl/nn-oaidl-itypeinfo
[GeneratedComInterface, Guid("00020401-0000-0000-c000-000000000046")]
public partial interface ITypeInfo
{
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-itypeinfo-gettypeattr
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTypeAttr(out TYPEATTR ppTypeAttr);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-itypeinfo-gettypecomp
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTypeComp(out ITypeComp ppTComp);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-itypeinfo-getfuncdesc
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFuncDesc(uint index, out FUNCDESC ppFuncDesc);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-itypeinfo-getvardesc
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVarDesc(uint index, out VARDESC ppVarDesc);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-itypeinfo-getnames
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetNames(int memid, out BSTR rgBstrNames, uint cMaxNames, out uint pcNames);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-itypeinfo-getreftypeofimpltype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRefTypeOfImplType(uint index, out uint pRefType);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-itypeinfo-getimpltypeflags
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetImplTypeFlags(uint index, out IMPLTYPEFLAGS pImplTypeFlags);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-itypeinfo-getidsofnames
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetIDsOfNames(in PWSTR rgszNames, uint cNames, out int pMemId);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-itypeinfo-invoke
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke(nint pvInstance, int memid, DISPATCH_FLAGS wFlags, ref DISPPARAMS pDispParams, out VARIANT pVarResult, out EXCEPINFO pExcepInfo, out uint puArgErr);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-itypeinfo-getdocumentation
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDocumentation(int memid, nint/* nint */ pBstrName, nint/* nint */ pBstrDocString, out uint pdwHelpContext, nint/* nint */ pBstrHelpFile);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-itypeinfo-getdllentry
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDllEntry(int memid, INVOKEKIND invKind, nint/* nint */ pBstrDllName, nint/* nint */ pBstrName, out ushort pwOrdinal);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-itypeinfo-getreftypeinfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRefTypeInfo(uint hRefType, out ITypeInfo ppTInfo);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-itypeinfo-addressofmember
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddressOfMember(int memid, INVOKEKIND invKind, out nint ppv);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-itypeinfo-createinstance
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateInstance(nint pUnkOuter, in Guid riid, out nint ppvObj);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-itypeinfo-getmops
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMops(int memid, out BSTR pBstrMops);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-itypeinfo-getcontainingtypelib
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetContainingTypeLib(out ITypeLib ppTLib, out uint pIndex);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-itypeinfo-releasetypeattr
    [PreserveSig]
    void ReleaseTypeAttr(in TYPEATTR pTypeAttr);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-itypeinfo-releasefuncdesc
    [PreserveSig]
    void ReleaseFuncDesc(in FUNCDESC pFuncDesc);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-itypeinfo-releasevardesc
    [PreserveSig]
    void ReleaseVarDesc(in VARDESC pVarDesc);
}
