namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d9/nn-d3d9-idirect3d9
[GeneratedComInterface, Guid("81bdcbca-64d4-426d-ae8d-ad0147f4275c")]
public partial interface IDirect3D9
{
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3d9-registersoftwaredevice
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT RegisterSoftwareDevice(nint pInitializeFunction);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3d9-getadaptercount
    [PreserveSig]
    public uint GetAdapterCount();
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3d9-getadapteridentifier
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetAdapterIdentifier(uint Adapter, uint Flags, ref D3DADAPTER_IDENTIFIER9 pIdentifier);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3d9-getadaptermodecount
    [PreserveSig]
    public uint GetAdapterModeCount(uint Adapter, D3DFORMAT Format);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3d9-enumadaptermodes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT EnumAdapterModes(uint Adapter, D3DFORMAT Format, uint Mode, ref D3DDISPLAYMODE pMode);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3d9-getadapterdisplaymode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetAdapterDisplayMode(uint Adapter, ref D3DDISPLAYMODE pMode);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3d9-checkdevicetype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CheckDeviceType(uint Adapter, D3DDEVTYPE DevType, D3DFORMAT AdapterFormat, D3DFORMAT BackBufferFormat, [MarshalAs(UnmanagedType.U4)] bool bWindowed);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3d9-checkdeviceformat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CheckDeviceFormat(uint Adapter, D3DDEVTYPE DeviceType, D3DFORMAT AdapterFormat, uint Usage, D3DRESOURCETYPE RType, D3DFORMAT CheckFormat);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3d9-checkdevicemultisampletype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CheckDeviceMultiSampleType(uint Adapter, D3DDEVTYPE DeviceType, D3DFORMAT SurfaceFormat, [MarshalAs(UnmanagedType.U4)] bool Windowed, D3DMULTISAMPLE_TYPE MultiSampleType, ref uint pQualityLevels);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3d9-checkdepthstencilmatch
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CheckDepthStencilMatch(uint Adapter, D3DDEVTYPE DeviceType, D3DFORMAT AdapterFormat, D3DFORMAT RenderTargetFormat, D3DFORMAT DepthStencilFormat);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3d9-checkdeviceformatconversion
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CheckDeviceFormatConversion(uint Adapter, D3DDEVTYPE DeviceType, D3DFORMAT SourceFormat, D3DFORMAT TargetFormat);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3d9-getdevicecaps
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetDeviceCaps(uint Adapter, D3DDEVTYPE DeviceType, ref D3DCAPS9 pCaps);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3d9-getadaptermonitor
    [PreserveSig]
    public HMONITOR GetAdapterMonitor(uint Adapter);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3d9-createdevice
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateDevice(uint Adapter, D3DDEVTYPE DeviceType, HWND hFocusWindow, uint BehaviorFlags, ref D3DPRESENT_PARAMETERS pPresentationParameters, out IDirect3DDevice9 ppReturnedDeviceInterface);
}
