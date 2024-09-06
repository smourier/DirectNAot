#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("f1df64b6-57fd-49cd-8807-c0eb88b45c8f")]
public partial interface ID3D12SwapChainAssistant
{
    [PreserveSig]
    LUID GetLUID();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSwapChainObject(in Guid riid, out nint /* void */ ppv);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCurrentResourceAndCommandQueue(in Guid riidResource, out nint /* void */ ppvResource, in Guid riidQueue, out nint /* void */ ppvQueue);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InsertImplicitSync();
}
