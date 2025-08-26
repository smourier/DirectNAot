#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/oaidl/nn-oaidl-itypeinfo2
[GeneratedComInterface, Guid("00020412-0000-0000-c000-000000000046")]
public partial interface ITypeInfo2 : ITypeInfo
{
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-itypeinfo2-gettypekind
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTypeKind(out TYPEKIND pTypeKind);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-itypeinfo2-gettypeflags
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTypeFlags(out uint pTypeFlags);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-itypeinfo2-getfuncindexofmemid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFuncIndexOfMemId(int memid, INVOKEKIND invKind, out uint pFuncIndex);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-itypeinfo2-getvarindexofmemid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVarIndexOfMemId(int memid, out uint pVarIndex);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-itypeinfo2-getcustdata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCustData(in Guid guid, out VARIANT pVarVal);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-itypeinfo2-getfunccustdata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFuncCustData(uint index, in Guid guid, out VARIANT pVarVal);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-itypeinfo2-getparamcustdata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetParamCustData(uint indexFunc, uint indexParam, in Guid guid, out VARIANT pVarVal);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-itypeinfo2-getvarcustdata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVarCustData(uint index, in Guid guid, out VARIANT pVarVal);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-itypeinfo2-getimpltypecustdata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetImplTypeCustData(uint index, in Guid guid, out VARIANT pVarVal);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-itypeinfo2-getdocumentation2
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDocumentation2(int memid, uint lcid, nint /* optional BSTR* */ pbstrHelpString, out uint pdwHelpStringContext, nint /* optional BSTR* */ pbstrHelpStringDll);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-itypeinfo2-getallcustdata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAllCustData(out CUSTDATA pCustData);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-itypeinfo2-getallfunccustdata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAllFuncCustData(uint index, out CUSTDATA pCustData);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-itypeinfo2-getallparamcustdata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAllParamCustData(uint indexFunc, uint indexParam, out CUSTDATA pCustData);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-itypeinfo2-getallvarcustdata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAllVarCustData(uint index, out CUSTDATA pCustData);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-itypeinfo2-getallimpltypecustdata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAllImplTypeCustData(uint index, out CUSTDATA pCustData);
}
