namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/audioengineendpoint/nn-audioengineendpoint-iaudioendpointoffloadstreammeter
[GeneratedComInterface, Guid("e1546dce-9dd1-418b-9ab2-348ced161c86")]
public partial interface IAudioEndpointOffloadStreamMeter
{
    // https://learn.microsoft.com/windows/win32/api/audioengineendpoint/nf-audioengineendpoint-iaudioendpointoffloadstreammeter-getmeterchannelcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMeterChannelCount(out uint pu32ChannelCount);
    
    // https://learn.microsoft.com/windows/win32/api/audioengineendpoint/nf-audioengineendpoint-iaudioendpointoffloadstreammeter-getmeteringdata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMeteringData(uint u32ChannelCount, out float pf32PeakValues);
}
