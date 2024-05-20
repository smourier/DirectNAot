#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d9/nn-d3d9-idirect3d9
[GeneratedComInterface, Guid("81bdcbca-64d4-426d-ae8d-ad0147f4275c")]
public partial interface IDirect3D9
{
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3d9-registersoftwaredevice
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RegisterSoftwareDevice(nint pInitializeFunction);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3d9-getadaptercount
    [PreserveSig]
    uint GetAdapterCount();
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3d9-getadapteridentifier
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAdapterIdentifier(uint Adapter, uint Flags, ref D3DADAPTER_IDENTIFIER9 pIdentifier);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3d9-getadaptermodecount
    [PreserveSig]
    uint GetAdapterModeCount(uint Adapter, D3DFORMAT Format);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3d9-enumadaptermodes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumAdapterModes(uint Adapter, D3DFORMAT Format, uint Mode, ref D3DDISPLAYMODE pMode);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3d9-getadapterdisplaymode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAdapterDisplayMode(uint Adapter, ref D3DDISPLAYMODE pMode);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3d9-checkdevicetype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CheckDeviceType(uint Adapter, D3DDEVTYPE DevType, D3DFORMAT AdapterFormat, D3DFORMAT BackBufferFormat, [MarshalAs(UnmanagedType.U4)] bool bWindowed);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3d9-checkdeviceformat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CheckDeviceFormat(uint Adapter, D3DDEVTYPE DeviceType, D3DFORMAT AdapterFormat, uint Usage, D3DRESOURCETYPE RType, D3DFORMAT CheckFormat);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3d9-checkdevicemultisampletype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CheckDeviceMultiSampleType(uint Adapter, D3DDEVTYPE DeviceType, D3DFORMAT SurfaceFormat, [MarshalAs(UnmanagedType.U4)] bool Windowed, D3DMULTISAMPLE_TYPE MultiSampleType, ref uint pQualityLevels);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3d9-checkdepthstencilmatch
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CheckDepthStencilMatch(uint Adapter, D3DDEVTYPE DeviceType, D3DFORMAT AdapterFormat, D3DFORMAT RenderTargetFormat, D3DFORMAT DepthStencilFormat);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3d9-checkdeviceformatconversion
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CheckDeviceFormatConversion(uint Adapter, D3DDEVTYPE DeviceType, D3DFORMAT SourceFormat, D3DFORMAT TargetFormat);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3d9-getdevicecaps
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDeviceCaps(uint Adapter, D3DDEVTYPE DeviceType, ref D3DCAPS9 pCaps);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3d9-getadaptermonitor
    [PreserveSig]
    HMONITOR GetAdapterMonitor(uint Adapter);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3d9-createdevice
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateDevice(uint Adapter, D3DDEVTYPE DeviceType, HWND hFocusWindow, uint BehaviorFlags, ref D3DPRESENT_PARAMETERS pPresentationParameters, out IDirect3DDevice9 ppReturnedDeviceInterface);
}
