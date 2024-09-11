#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11sdklayers/nn-d3d11sdklayers-id3d11debug
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("79cf2233-7536-4948-9d36-1e4692dc5760")]
public partial interface ID3D11Debug
{
    // https://learn.microsoft.com/windows/win32/api/d3d11sdklayers/nf-d3d11sdklayers-id3d11debug-setfeaturemask
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFeatureMask(uint Mask);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11sdklayers/nf-d3d11sdklayers-id3d11debug-getfeaturemask
    [PreserveSig]
    uint GetFeatureMask();
    
    // https://learn.microsoft.com/windows/win32/api/d3d11sdklayers/nf-d3d11sdklayers-id3d11debug-setpresentperrenderopdelay
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPresentPerRenderOpDelay(uint Milliseconds);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11sdklayers/nf-d3d11sdklayers-id3d11debug-getpresentperrenderopdelay
    [PreserveSig]
    uint GetPresentPerRenderOpDelay();
    
    // https://learn.microsoft.com/windows/win32/api/d3d11sdklayers/nf-d3d11sdklayers-id3d11debug-setswapchain
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSwapChain([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDXGISwapChain?>))] IDXGISwapChain? pSwapChain);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11sdklayers/nf-d3d11sdklayers-id3d11debug-getswapchain
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSwapChain([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDXGISwapChain>))] out IDXGISwapChain ppSwapChain);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11sdklayers/nf-d3d11sdklayers-id3d11debug-validatecontext
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ValidateContext([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11DeviceContext>))] ID3D11DeviceContext pContext);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11sdklayers/nf-d3d11sdklayers-id3d11debug-reportlivedeviceobjects
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ReportLiveDeviceObjects(D3D11_RLDO_FLAGS Flags);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11sdklayers/nf-d3d11sdklayers-id3d11debug-validatecontextfordispatch
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ValidateContextForDispatch([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11DeviceContext>))] ID3D11DeviceContext pContext);
}
