#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxgi/nn-dxgi-idxgiadapter1
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("29038f61-3839-4626-91fd-086879011a05")]
public partial interface IDXGIAdapter1 : IDXGIAdapter
{
    // https://learn.microsoft.com/windows/win32/api/dxgi/nf-dxgi-idxgiadapter1-getdesc1
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDesc1(out DXGI_ADAPTER_DESC1 pDesc);
}
