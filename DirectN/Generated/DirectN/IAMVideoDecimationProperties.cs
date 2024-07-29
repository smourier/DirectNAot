#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-iamvideodecimationproperties
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("60d32930-13da-11d3-9ec6-c4fcaef5c7be")]
public partial interface IAMVideoDecimationProperties
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamvideodecimationproperties-querydecimationusage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT QueryDecimationUsage(out DECIMATION_USAGE lpUsage);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamvideodecimationproperties-setdecimationusage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDecimationUsage(DECIMATION_USAGE Usage);
}
