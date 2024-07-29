#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("2852dd88-b484-4c0c-b6b1-67168500e600")]
public partial interface ID3D12InfoQueue1 : ID3D12InfoQueue
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RegisterMessageCallback(D3D12MessageFunc CallbackFunc, D3D12_MESSAGE_CALLBACK_FLAGS CallbackFilterFlags, nint pContext, ref uint pCallbackCookie);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UnregisterMessageCallback(uint CallbackCookie);
}
