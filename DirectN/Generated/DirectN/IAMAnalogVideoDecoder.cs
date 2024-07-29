#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-iamanalogvideodecoder
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("c6e13350-30ac-11d0-a18c-00a0c9118956")]
public partial interface IAMAnalogVideoDecoder
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamanalogvideodecoder-get_availabletvformats
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_AvailableTVFormats(out int lAnalogVideoStandard);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamanalogvideodecoder-put_tvformat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_TVFormat(int lAnalogVideoStandard);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamanalogvideodecoder-get_tvformat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_TVFormat(out int plAnalogVideoStandard);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamanalogvideodecoder-get_horizontallocked
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_HorizontalLocked(out int plLocked);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamanalogvideodecoder-put_vcrhorizontallocking
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_VCRHorizontalLocking(int lVCRHorizontalLocking);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamanalogvideodecoder-get_vcrhorizontallocking
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_VCRHorizontalLocking(out int plVCRHorizontalLocking);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamanalogvideodecoder-get_numberoflines
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_NumberOfLines(out int plNumberOfLines);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamanalogvideodecoder-put_outputenable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_OutputEnable(int lOutputEnable);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamanalogvideodecoder-get_outputenable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_OutputEnable(out int plOutputEnable);
}
