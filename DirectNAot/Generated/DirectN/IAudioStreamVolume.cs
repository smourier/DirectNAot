#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/audioclient/nn-audioclient-iaudiostreamvolume
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("93014887-242d-4068-8a15-cf5e93b90fe3")]
public partial interface IAudioStreamVolume
{
    // https://learn.microsoft.com/windows/win32/api/audioclient/nf-audioclient-iaudiostreamvolume-getchannelcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetChannelCount(out uint pdwCount);
    
    // https://learn.microsoft.com/windows/win32/api/audioclient/nf-audioclient-iaudiostreamvolume-setchannelvolume
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetChannelVolume(uint dwIndex, float fLevel);
    
    // https://learn.microsoft.com/windows/win32/api/audioclient/nf-audioclient-iaudiostreamvolume-getchannelvolume
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetChannelVolume(uint dwIndex, out float pfLevel);
    
    // https://learn.microsoft.com/windows/win32/api/audioclient/nf-audioclient-iaudiostreamvolume-setallvolumes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAllVolumes(uint dwCount, [MarshalUsing(CountElementName = nameof(dwCount))] in float[] pfVolumes);
    
    // https://learn.microsoft.com/windows/win32/api/audioclient/nf-audioclient-iaudiostreamvolume-getallvolumes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAllVolumes(uint dwCount, [MarshalUsing(CountElementName = nameof(dwCount))] out float[] pfVolumes);
}
