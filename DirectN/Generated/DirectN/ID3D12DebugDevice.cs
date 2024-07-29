#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12sdklayers/nn-d3d12sdklayers-id3d12debugdevice
[GeneratedComInterface, Guid("3febd6dd-4973-4787-8194-e45f9e28923e")]
public partial interface ID3D12DebugDevice
{
    // https://learn.microsoft.com/windows/win32/api/d3d12sdklayers/nf-d3d12sdklayers-id3d12debugdevice-setfeaturemask
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFeatureMask(D3D12_DEBUG_FEATURE Mask);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12sdklayers/nf-d3d12sdklayers-id3d12debugdevice-getfeaturemask
    [PreserveSig]
    D3D12_DEBUG_FEATURE GetFeatureMask();
    
    // https://learn.microsoft.com/windows/win32/api/d3d12sdklayers/nf-d3d12sdklayers-id3d12debugdevice-reportlivedeviceobjects
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ReportLiveDeviceObjects(D3D12_RLDO_FLAGS Flags);
}
