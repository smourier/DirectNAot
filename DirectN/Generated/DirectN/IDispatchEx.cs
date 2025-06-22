#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("a6ef9860-c720-11d0-9337-00a0c90dcaa9")]
public partial interface IDispatchEx : IDispatch
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDispID(BSTR bstrName, uint grfdex, out int pid);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InvokeEx(int id, uint lcid, ushort wFlags, in DISPPARAMS pdp, nint /* optional VARIANT* */ pvarRes, nint /* optional EXCEPINFO* */ pei, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IServiceProvider?>))] IServiceProvider? pspCaller);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DeleteMemberByName(BSTR bstrName, uint grfdex);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DeleteMemberByDispID(int id);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMemberProperties(int id, uint grfdexFetch, out FDEX_PROP_FLAGS pgrfdex);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMemberName(int id, out BSTR pbstrName);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetNextDispID(uint grfdex, int id, out int pid);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetNameSpaceParent(out nint ppunk);
}
