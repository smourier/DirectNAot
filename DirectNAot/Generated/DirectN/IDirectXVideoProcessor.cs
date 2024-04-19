﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxva2api/nn-dxva2api-idirectxvideoprocessor
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("8c3a39f0-916e-4690-804f-4c8001355d25")]
public partial interface IDirectXVideoProcessor
{
    // https://learn.microsoft.com/windows/win32/api/dxva2api/nf-dxva2api-idirectxvideoprocessor-getvideoprocessorservice
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVideoProcessorService(out IDirectXVideoProcessorService ppService);
    
    // https://learn.microsoft.com/windows/win32/api/dxva2api/nf-dxva2api-idirectxvideoprocessor-getcreationparameters
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCreationParameters(nint/* nint */ pDeviceGuid, nint/* nint */ pVideoDesc, nint/* nint */ pRenderTargetFormat, nint/* nint */ pMaxNumSubStreams);
    
    // https://learn.microsoft.com/windows/win32/api/dxva2api/nf-dxva2api-idirectxvideoprocessor-getvideoprocessorcaps
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVideoProcessorCaps(out DXVA2_VideoProcessorCaps pCaps);
    
    // https://learn.microsoft.com/windows/win32/api/dxva2api/nf-dxva2api-idirectxvideoprocessor-getprocamprange
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetProcAmpRange(uint ProcAmpCap, out DXVA2_ValueRange pRange);
    
    // https://learn.microsoft.com/windows/win32/api/dxva2api/nf-dxva2api-idirectxvideoprocessor-getfilterpropertyrange
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFilterPropertyRange(uint FilterSetting, out DXVA2_ValueRange pRange);
    
    // https://learn.microsoft.com/windows/win32/api/dxva2api/nf-dxva2api-idirectxvideoprocessor-videoprocessblt
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT VideoProcessBlt(IDirect3DSurface9 pRenderTarget, in DXVA2_VideoProcessBltParams pBltParams, MediaFoundationDXVA2_VideoSample pSamples, uint NumSamples, nint/* nint */ pHandleComplete);
}
