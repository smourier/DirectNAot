#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxgi1_4/nn-dxgi1_4-idxgifactory4
[GeneratedComInterface, Guid("1bc6ea02-ef36-464f-bf0c-21ca39e5168a")]
public partial interface IDXGIFactory4 : IDXGIFactory3
{
    // https://learn.microsoft.com/windows/win32/api/dxgi1_4/nf-dxgi1_4-idxgifactory4-enumadapterbyluid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumAdapterByLuid(LUID AdapterLuid, in Guid riid, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<object>))] out object /* void */ ppvAdapter);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi1_4/nf-dxgi1_4-idxgifactory4-enumwarpadapter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumWarpAdapter(in Guid riid, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<object>))] out object /* void */ ppvAdapter);
}
