namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxva2api/nn-dxva2api-idirectxvideodecoder
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("f2b0810a-fd00-43c9-918c-df94e2d8ef7d")]
public partial interface IDirectXVideoDecoder
{
    // https://learn.microsoft.com/windows/win32/api/dxva2api/nf-dxva2api-idirectxvideodecoder-getvideodecoderservice
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVideoDecoderService(out IDirectXVideoDecoderService ppService);
    
    // https://learn.microsoft.com/windows/win32/api/dxva2api/nf-dxva2api-idirectxvideodecoder-getcreationparameters
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCreationParameters(nint /* optional Guid* */ pDeviceGuid, nint /* optional DXVA2_VideoDesc* */ pVideoDesc, nint /* optional DXVA2_ConfigPictureDecode* */ pConfig, [MarshalUsing(CountElementName = nameof(pNumSurfaces))] out IDirect3DSurface9[] pDecoderRenderTargets, nint /* optional uint* */ pNumSurfaces);
    
    // https://learn.microsoft.com/windows/win32/api/dxva2api/nf-dxva2api-idirectxvideodecoder-getbuffer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBuffer(uint BufferType, out nint ppBuffer, out uint pBufferSize);
    
    // https://learn.microsoft.com/windows/win32/api/dxva2api/nf-dxva2api-idirectxvideodecoder-releasebuffer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ReleaseBuffer(uint BufferType);
    
    // https://learn.microsoft.com/windows/win32/api/dxva2api/nf-dxva2api-idirectxvideodecoder-beginframe
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT BeginFrame(IDirect3DSurface9 pRenderTarget, nint /* optional void* */ pvPVPData);
    
    // https://learn.microsoft.com/windows/win32/api/dxva2api/nf-dxva2api-idirectxvideodecoder-endframe
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EndFrame(nint /* optional HANDLE* */ pHandleComplete);
    
    // https://learn.microsoft.com/windows/win32/api/dxva2api/nf-dxva2api-idirectxvideodecoder-execute
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Execute(in DXVA2_DecodeExecuteParams pExecuteParams);
}
