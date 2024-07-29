#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxva2api/nn-dxva2api-idirectxvideodecoderservice
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("fc51a551-d5e7-11d9-af55-00054e43ff02")]
public partial interface IDirectXVideoDecoderService : IDirectXVideoAccelerationService
{
    // https://learn.microsoft.com/windows/win32/api/dxva2api/nf-dxva2api-idirectxvideodecoderservice-getdecoderdeviceguids
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDecoderDeviceGuids(out uint pCount, out nint pGuids);
    
    // https://learn.microsoft.com/windows/win32/api/dxva2api/nf-dxva2api-idirectxvideodecoderservice-getdecoderrendertargets
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDecoderRenderTargets(in Guid Guid, out uint pCount, out nint pFormats);
    
    // https://learn.microsoft.com/windows/win32/api/dxva2api/nf-dxva2api-idirectxvideodecoderservice-getdecoderconfigurations
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDecoderConfigurations(in Guid Guid, in DXVA2_VideoDesc pVideoDesc, nint /* optional void* */ pReserved, out uint pCount, out nint ppConfigs);
    
    // https://learn.microsoft.com/windows/win32/api/dxva2api/nf-dxva2api-idirectxvideodecoderservice-createvideodecoder
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateVideoDecoder(in Guid Guid, in DXVA2_VideoDesc pVideoDesc, in DXVA2_ConfigPictureDecode pConfig, [In][MarshalUsing(CountElementName = nameof(NumRenderTargets))] IDirect3DSurface9[] ppDecoderRenderTargets, uint NumRenderTargets, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDirectXVideoDecoder>))] out IDirectXVideoDecoder ppDecode);
}
