#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxgi1_2/nn-dxgi1_2-idxgiadapter2
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("0aa1ae0a-fa0e-4b84-8644-e05ff8e5acb5")]
public partial interface IDXGIAdapter2 : IDXGIAdapter1
{
    // https://learn.microsoft.com/windows/win32/api/dxgi1_2/nf-dxgi1_2-idxgiadapter2-getdesc2
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDesc2(out DXGI_ADAPTER_DESC2 pDesc);
}
