#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12sdklayers/nn-d3d12sdklayers-id3d12debugdevice1
[GeneratedComInterface, Guid("a9b71770-d099-4a65-a698-3dee10020f88")]
public partial interface ID3D12DebugDevice1
{
    // https://learn.microsoft.com/windows/win32/api/d3d12sdklayers/nf-d3d12sdklayers-id3d12debugdevice1-setdebugparameter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDebugParameter(D3D12_DEBUG_DEVICE_PARAMETER_TYPE Type, nint pData, uint DataSize);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12sdklayers/nf-d3d12sdklayers-id3d12debugdevice1-getdebugparameter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDebugParameter(D3D12_DEBUG_DEVICE_PARAMETER_TYPE Type, nint pData, uint DataSize);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12sdklayers/nf-d3d12sdklayers-id3d12debugdevice1-reportlivedeviceobjects
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ReportLiveDeviceObjects(D3D12_RLDO_FLAGS Flags);
}
