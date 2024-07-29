#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d9/nn-d3d9-idirect3d9ex
[GeneratedComInterface, Guid("02177241-69fc-400c-8ff1-93a44df6861d")]
public partial interface IDirect3D9Ex : IDirect3D9
{
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3d9ex-getadaptermodecountex
    [PreserveSig]
    uint GetAdapterModeCountEx(uint Adapter, in D3DDISPLAYMODEFILTER pFilter);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3d9ex-enumadaptermodesex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumAdapterModesEx(uint Adapter, in D3DDISPLAYMODEFILTER pFilter, uint Mode, ref D3DDISPLAYMODEEX pMode);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3d9ex-getadapterdisplaymodeex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAdapterDisplayModeEx(uint Adapter, ref D3DDISPLAYMODEEX pMode, ref D3DDISPLAYROTATION pRotation);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3d9ex-createdeviceex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateDeviceEx(uint Adapter, D3DDEVTYPE DeviceType, HWND hFocusWindow, uint BehaviorFlags, ref D3DPRESENT_PARAMETERS pPresentationParameters, ref D3DDISPLAYMODEEX pFullscreenDisplayMode, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDirect3DDevice9Ex>))] out IDirect3DDevice9Ex ppReturnedDeviceInterface);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3d9ex-getadapterluid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAdapterLUID(uint Adapter, ref LUID pLUID);
}
