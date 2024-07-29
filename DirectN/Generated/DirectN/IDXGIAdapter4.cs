#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxgi1_6/nn-dxgi1_6-idxgiadapter4
[GeneratedComInterface, Guid("3c8d99d1-4fbf-4181-a82c-af66bf7bd24e")]
public partial interface IDXGIAdapter4 : IDXGIAdapter3
{
    // https://learn.microsoft.com/windows/win32/api/dxgi1_6/nf-dxgi1_6-idxgiadapter4-getdesc3
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDesc3(out DXGI_ADAPTER_DESC3 pDesc);
}
