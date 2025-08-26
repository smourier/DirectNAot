#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/oaidl/nn-oaidl-itypelib2
[GeneratedComInterface, Guid("00020411-0000-0000-c000-000000000046")]
public partial interface ITypeLib2 : ITypeLib
{
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-itypelib2-getcustdata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCustData(in Guid guid, out VARIANT pVarVal);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-itypelib2-getlibstatistics
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLibStatistics(out uint pcUniqueNames, out uint pcchUniqueNames);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-itypelib2-getdocumentation2
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDocumentation2(int index, uint lcid, nint /* optional BSTR* */ pbstrHelpString, out uint pdwHelpStringContext, nint /* optional BSTR* */ pbstrHelpStringDll);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-itypelib2-getallcustdata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAllCustData(out CUSTDATA pCustData);
}
