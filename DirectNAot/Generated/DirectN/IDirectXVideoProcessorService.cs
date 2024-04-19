namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxva2api/nn-dxva2api-idirectxvideoprocessorservice
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("fc51a552-d5e7-11d9-af55-00054e43ff02")]
public partial interface IDirectXVideoProcessorService : IDirectXVideoAccelerationService
{
    // https://learn.microsoft.com/windows/win32/api/dxva2api/nf-dxva2api-idirectxvideoprocessorservice-registervideoprocessorsoftwaredevice
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RegisterVideoProcessorSoftwareDevice(nint pCallbacks);
    
    // https://learn.microsoft.com/windows/win32/api/dxva2api/nf-dxva2api-idirectxvideoprocessorservice-getvideoprocessordeviceguids
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVideoProcessorDeviceGuids(in DXVA2_VideoDesc pVideoDesc, out uint pCount, out Guid pGuids);
    
    // https://learn.microsoft.com/windows/win32/api/dxva2api/nf-dxva2api-idirectxvideoprocessorservice-getvideoprocessorrendertargets
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVideoProcessorRenderTargets(in Guid VideoProcDeviceGuid, in DXVA2_VideoDesc pVideoDesc, out uint pCount, out D3DFORMAT pFormats);
    
    // https://learn.microsoft.com/windows/win32/api/dxva2api/nf-dxva2api-idirectxvideoprocessorservice-getvideoprocessorsubstreamformats
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVideoProcessorSubStreamFormats(in Guid VideoProcDeviceGuid, in DXVA2_VideoDesc pVideoDesc, D3DFORMAT RenderTargetFormat, out uint pCount, out D3DFORMAT pFormats);
    
    // https://learn.microsoft.com/windows/win32/api/dxva2api/nf-dxva2api-idirectxvideoprocessorservice-getvideoprocessorcaps
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVideoProcessorCaps(in Guid VideoProcDeviceGuid, in DXVA2_VideoDesc pVideoDesc, D3DFORMAT RenderTargetFormat, out DXVA2_VideoProcessorCaps pCaps);
    
    // https://learn.microsoft.com/windows/win32/api/dxva2api/nf-dxva2api-idirectxvideoprocessorservice-getprocamprange
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetProcAmpRange(in Guid VideoProcDeviceGuid, in DXVA2_VideoDesc pVideoDesc, D3DFORMAT RenderTargetFormat, uint ProcAmpCap, out DXVA2_ValueRange pRange);
    
    // https://learn.microsoft.com/windows/win32/api/dxva2api/nf-dxva2api-idirectxvideoprocessorservice-getfilterpropertyrange
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFilterPropertyRange(in Guid VideoProcDeviceGuid, in DXVA2_VideoDesc pVideoDesc, D3DFORMAT RenderTargetFormat, uint FilterSetting, out DXVA2_ValueRange pRange);
    
    // https://learn.microsoft.com/windows/win32/api/dxva2api/nf-dxva2api-idirectxvideoprocessorservice-createvideoprocessor
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateVideoProcessor(in Guid VideoProcDeviceGuid, in DXVA2_VideoDesc pVideoDesc, D3DFORMAT RenderTargetFormat, uint MaxNumSubStreams, out IDirectXVideoProcessor ppVidProcess);
}
