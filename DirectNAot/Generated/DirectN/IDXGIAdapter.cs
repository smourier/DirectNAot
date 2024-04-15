namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxgi/nn-dxgi-idxgiadapter
[GeneratedComInterface, Guid("2411e7e1-12ac-4ccf-bd14-9798e8534dc0")]
public partial interface IDXGIAdapter : IDXGIObject
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumOutputs(uint Output, out IDXGIOutput ppOutput);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDesc(out DXGI_ADAPTER_DESC pDesc);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CheckInterfaceSupport(Guid InterfaceName, out long pUMDVersion);
}
