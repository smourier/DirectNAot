namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/oaidl/nn-oaidl-itypeinfo
[GeneratedComInterface, Guid("00020401-0000-0000-c000-000000000046")]
public partial interface ITypeInfo
{
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-itypeinfo-gettypeattr
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetTypeAttr(out TYPEATTR ppTypeAttr);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-itypeinfo-gettypecomp
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetTypeComp(out ITypeComp ppTComp);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-itypeinfo-getfuncdesc
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetFuncDesc(uint index, out FUNCDESC ppFuncDesc);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-itypeinfo-getvardesc
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetVarDesc(uint index, out VARDESC ppVarDesc);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-itypeinfo-getnames
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetNames(int memid, out BSTR rgBstrNames, uint cMaxNames, out uint pcNames);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-itypeinfo-getreftypeofimpltype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetRefTypeOfImplType(uint index, out uint pRefType);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-itypeinfo-getimpltypeflags
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetImplTypeFlags(uint index, out IMPLTYPEFLAGS pImplTypeFlags);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-itypeinfo-getidsofnames
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetIDsOfNames(in PWSTR rgszNames, uint cNames, out int pMemId);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-itypeinfo-invoke
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT Invoke(nint pvInstance, int memid, DISPATCH_FLAGS wFlags, ref DISPPARAMS pDispParams, out VARIANT pVarResult, out EXCEPINFO pExcepInfo, out uint puArgErr);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-itypeinfo-getdocumentation
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetDocumentation(int memid, nint/* nint */ pBstrName, nint/* nint */ pBstrDocString, out uint pdwHelpContext, nint/* nint */ pBstrHelpFile);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-itypeinfo-getdllentry
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetDllEntry(int memid, INVOKEKIND invKind, nint/* nint */ pBstrDllName, nint/* nint */ pBstrName, out ushort pwOrdinal);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-itypeinfo-getreftypeinfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetRefTypeInfo(uint hRefType, out ITypeInfo ppTInfo);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-itypeinfo-addressofmember
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT AddressOfMember(int memid, INVOKEKIND invKind, out nint ppv);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-itypeinfo-createinstance
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateInstance(nint pUnkOuter, in Guid riid, out nint ppvObj);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-itypeinfo-getmops
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetMops(int memid, out BSTR pBstrMops);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-itypeinfo-getcontainingtypelib
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetContainingTypeLib(out ITypeLib ppTLib, out uint pIndex);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-itypeinfo-releasetypeattr
    [PreserveSig]
    public void ReleaseTypeAttr(in TYPEATTR pTypeAttr);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-itypeinfo-releasefuncdesc
    [PreserveSig]
    public void ReleaseFuncDesc(in FUNCDESC pFuncDesc);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-itypeinfo-releasevardesc
    [PreserveSig]
    public void ReleaseVarDesc(in VARDESC pVarDesc);
}
