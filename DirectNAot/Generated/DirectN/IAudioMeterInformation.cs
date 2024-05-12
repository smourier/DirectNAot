#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/endpointvolume/nn-endpointvolume-iaudiometerinformation
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("c02216f6-8c67-4b5b-9d00-d008e73e0064")]
public partial interface IAudioMeterInformation
{
    // https://learn.microsoft.com/windows/win32/api/endpointvolume/nf-endpointvolume-iaudiometerinformation-getpeakvalue
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPeakValue(out float pfPeak);
    
    // https://learn.microsoft.com/windows/win32/api/endpointvolume/nf-endpointvolume-iaudiometerinformation-getmeteringchannelcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMeteringChannelCount(out uint pnChannelCount);
    
    // https://learn.microsoft.com/windows/win32/api/endpointvolume/nf-endpointvolume-iaudiometerinformation-getchannelspeakvalues
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetChannelsPeakValues(uint u32ChannelCount, [MarshalUsing(CountElementName = nameof(u32ChannelCount))] ref float[] afPeakValues);
    
    // https://learn.microsoft.com/windows/win32/api/endpointvolume/nf-endpointvolume-iaudiometerinformation-queryhardwaresupport
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT QueryHardwareSupport(out uint pdwHardwareSupportMask);
}
