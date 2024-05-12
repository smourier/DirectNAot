#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/oaidl/nn-oaidl-idispatch
[GeneratedComInterface, Guid("00020400-0000-0000-c000-000000000046")]
public partial interface IDispatch
{
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-idispatch-gettypeinfocount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTypeInfoCount(out uint pctinfo);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-idispatch-gettypeinfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTypeInfo(uint iTInfo, uint lcid, out ITypeInfo ppTInfo);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-idispatch-getidsofnames
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetIDsOfNames(in Guid riid, [MarshalUsing(CountElementName = nameof(cNames))] in PWSTR[] rgszNames, uint cNames, uint lcid, [In][Out][MarshalUsing(CountElementName = nameof(cNames))] int[] rgDispId);
    
    // https://learn.microsoft.com/windows/win32/api/oaidl/nf-oaidl-idispatch-invoke
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke(int dispIdMember, in Guid riid, uint lcid, DISPATCH_FLAGS wFlags, in DISPPARAMS pDispParams, nint /* optional VARIANT* */ pVarResult, nint /* optional EXCEPINFO* */ pExcepInfo, nint /* optional uint* */ puArgErr);
}
