namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxgi1_4/nn-dxgi1_4-idxgifactory4
[GeneratedComInterface, Guid("1bc6ea02-ef36-464f-bf0c-21ca39e5168a")]
public partial interface IDXGIFactory4 : IDXGIFactory3
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumAdapterByLuid(LUID AdapterLuid, Guid riid, out nint ppvAdapter);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumWarpAdapter(Guid riid, out nint ppvAdapter);
}
