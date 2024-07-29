#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxvahd/nn-dxvahd-idxvahd_device
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("95f12dfd-d77e-49be-815f-57d579634d6d")]
public partial interface IDXVAHD_Device
{
    // https://learn.microsoft.com/windows/win32/api/dxvahd/nf-dxvahd-idxvahd_device-createvideosurface
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateVideoSurface(uint Width, uint Height, D3DFORMAT Format, D3DPOOL Pool, uint Usage, DXVAHD_SURFACE_TYPE Type, uint NumSurfaces, [In][Out][MarshalUsing(CountElementName = nameof(NumSurfaces))] IDirect3DSurface9[] ppSurfaces, nint /* optional HANDLE* */ pSharedHandle);
    
    // https://learn.microsoft.com/windows/win32/api/dxvahd/nf-dxvahd-idxvahd_device-getvideoprocessordevicecaps
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVideoProcessorDeviceCaps(out DXVAHD_VPDEVCAPS pCaps);
    
    // https://learn.microsoft.com/windows/win32/api/dxvahd/nf-dxvahd-idxvahd_device-getvideoprocessoroutputformats
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVideoProcessorOutputFormats(uint Count, [In][Out][MarshalUsing(CountElementName = nameof(Count))] D3DFORMAT[] pFormats);
    
    // https://learn.microsoft.com/windows/win32/api/dxvahd/nf-dxvahd-idxvahd_device-getvideoprocessorinputformats
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVideoProcessorInputFormats(uint Count, [In][Out][MarshalUsing(CountElementName = nameof(Count))] D3DFORMAT[] pFormats);
    
    // https://learn.microsoft.com/windows/win32/api/dxvahd/nf-dxvahd-idxvahd_device-getvideoprocessorcaps
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVideoProcessorCaps(uint Count, [In][Out][MarshalUsing(CountElementName = nameof(Count))] DXVAHD_VPCAPS[] pCaps);
    
    // https://learn.microsoft.com/windows/win32/api/dxvahd/nf-dxvahd-idxvahd_device-getvideoprocessorcustomrates
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVideoProcessorCustomRates(in Guid pVPGuid, uint Count, [In][Out][MarshalUsing(CountElementName = nameof(Count))] DXVAHD_CUSTOM_RATE_DATA[] pRates);
    
    // https://learn.microsoft.com/windows/win32/api/dxvahd/nf-dxvahd-idxvahd_device-getvideoprocessorfilterrange
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVideoProcessorFilterRange(DXVAHD_FILTER Filter, out DXVAHD_FILTER_RANGE_DATA pRange);
    
    // https://learn.microsoft.com/windows/win32/api/dxvahd/nf-dxvahd-idxvahd_device-createvideoprocessor
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateVideoProcessor(in Guid pVPGuid, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDXVAHD_VideoProcessor>))] out IDXVAHD_VideoProcessor ppVideoProcessor);
}
