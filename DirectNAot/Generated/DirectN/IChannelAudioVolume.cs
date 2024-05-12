#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/audioclient/nn-audioclient-ichannelaudiovolume
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("1c158861-b533-4b30-b1cf-e853e51c59b8")]
public partial interface IChannelAudioVolume
{
    // https://learn.microsoft.com/windows/win32/api/audioclient/nf-audioclient-ichannelaudiovolume-getchannelcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetChannelCount(out uint pdwCount);
    
    // https://learn.microsoft.com/windows/win32/api/audioclient/nf-audioclient-ichannelaudiovolume-setchannelvolume
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetChannelVolume(uint dwIndex, float fLevel, in Guid EventContext);
    
    // https://learn.microsoft.com/windows/win32/api/audioclient/nf-audioclient-ichannelaudiovolume-getchannelvolume
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetChannelVolume(uint dwIndex, out float pfLevel);
    
    // https://learn.microsoft.com/windows/win32/api/audioclient/nf-audioclient-ichannelaudiovolume-setallvolumes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAllVolumes(uint dwCount, [MarshalUsing(CountElementName = nameof(dwCount))] in float[] pfVolumes, in Guid EventContext);
    
    // https://learn.microsoft.com/windows/win32/api/audioclient/nf-audioclient-ichannelaudiovolume-getallvolumes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAllVolumes(uint dwCount, [In][Out][MarshalUsing(CountElementName = nameof(dwCount))] float[] pfVolumes);
}
