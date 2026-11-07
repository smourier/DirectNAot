#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("9464643c-c95b-4674-8a7d-ee0548e8c022")]
public partial interface IDXGIAdapter5 : IDXGIAdapter4
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDesc4(out DXGI_ADAPTER_DESC4 pDesc);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSingleAdapterHybridMode(out DXGI_SINGLE_ADAPTER_HYBRID_MODE pSingleAdapterHybridMode);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSingleAdapterHybridMode(DXGI_SINGLE_ADAPTER_HYBRID_MODE SingleAdapterHybridMode);
}
