#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("c3a9f406-2222-436d-86d5-ba3229279efb")]
public partial interface IMSEventBinder : IDispatch
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Bind(IDispatch pEventObject, BSTR EventName, BSTR EventHandler, out int CancelID);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Unbind(uint CancelCookie);
}
