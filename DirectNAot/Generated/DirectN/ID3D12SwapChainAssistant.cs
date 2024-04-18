namespace DirectN;

[GeneratedComInterface, Guid("f1df64b6-57fd-49cd-8807-c0eb88b45c8f")]
public partial interface ID3D12SwapChainAssistant
{
    [PreserveSig]
    public LUID GetLUID();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetSwapChainObject(in Guid riid, out nint ppv);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetCurrentResourceAndCommandQueue(in Guid riidResource, out nint ppvResource, in Guid riidQueue, out nint ppvQueue);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT InsertImplicitSync();
}
