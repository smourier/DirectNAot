#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/evr9/nn-evr9-imfvideoprocessor
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("6ab0000c-fece-4d1f-a2ac-a9573530656e")]
public partial interface IMFVideoProcessor
{
    // https://learn.microsoft.com/windows/win32/api/evr9/nf-evr9-imfvideoprocessor-getavailablevideoprocessormodes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAvailableVideoProcessorModes(ref uint lpdwNumProcessingModes, out nint ppVideoProcessingModes);
    
    // https://learn.microsoft.com/windows/win32/api/evr9/nf-evr9-imfvideoprocessor-getvideoprocessorcaps
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVideoProcessorCaps(in Guid lpVideoProcessorMode, out DXVA2_VideoProcessorCaps lpVideoProcessorCaps);
    
    // https://learn.microsoft.com/windows/win32/api/evr9/nf-evr9-imfvideoprocessor-getvideoprocessormode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVideoProcessorMode(out Guid lpMode);
    
    // https://learn.microsoft.com/windows/win32/api/evr9/nf-evr9-imfvideoprocessor-setvideoprocessormode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetVideoProcessorMode(in Guid lpMode);
    
    // https://learn.microsoft.com/windows/win32/api/evr9/nf-evr9-imfvideoprocessor-getprocamprange
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetProcAmpRange(uint dwProperty, out DXVA2_ValueRange pPropRange);
    
    // https://learn.microsoft.com/windows/win32/api/evr9/nf-evr9-imfvideoprocessor-getprocampvalues
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetProcAmpValues(uint dwFlags, out DXVA2_ProcAmpValues Values);
    
    // https://learn.microsoft.com/windows/win32/api/evr9/nf-evr9-imfvideoprocessor-setprocampvalues
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetProcAmpValues(uint dwFlags, in DXVA2_ProcAmpValues pValues);
    
    // https://learn.microsoft.com/windows/win32/api/evr9/nf-evr9-imfvideoprocessor-getfilteringrange
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFilteringRange(uint dwProperty, out DXVA2_ValueRange pPropRange);
    
    // https://learn.microsoft.com/windows/win32/api/evr9/nf-evr9-imfvideoprocessor-getfilteringvalue
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFilteringValue(uint dwProperty, out DXVA2_Fixed32 pValue);
    
    // https://learn.microsoft.com/windows/win32/api/evr9/nf-evr9-imfvideoprocessor-setfilteringvalue
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFilteringValue(uint dwProperty, in DXVA2_Fixed32 pValue);
    
    // https://learn.microsoft.com/windows/win32/api/evr9/nf-evr9-imfvideoprocessor-getbackgroundcolor
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBackgroundColor(out COLORREF lpClrBkg);
    
    // https://learn.microsoft.com/windows/win32/api/evr9/nf-evr9-imfvideoprocessor-setbackgroundcolor
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetBackgroundColor(COLORREF ClrBkg);
}
