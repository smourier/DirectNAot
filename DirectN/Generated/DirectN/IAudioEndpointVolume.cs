#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/endpointvolume/nn-endpointvolume-iaudioendpointvolume
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("5cdf2c82-841e-4546-9722-0cf74078229a")]
public partial interface IAudioEndpointVolume
{
    // https://learn.microsoft.com/windows/win32/api/endpointvolume/nf-endpointvolume-iaudioendpointvolume-registercontrolchangenotify
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RegisterControlChangeNotify(IAudioEndpointVolumeCallback pNotify);
    
    // https://learn.microsoft.com/windows/win32/api/endpointvolume/nf-endpointvolume-iaudioendpointvolume-unregistercontrolchangenotify
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UnregisterControlChangeNotify(IAudioEndpointVolumeCallback pNotify);
    
    // https://learn.microsoft.com/windows/win32/api/endpointvolume/nf-endpointvolume-iaudioendpointvolume-getchannelcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetChannelCount(out uint pnChannelCount);
    
    // https://learn.microsoft.com/windows/win32/api/endpointvolume/nf-endpointvolume-iaudioendpointvolume-setmastervolumelevel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetMasterVolumeLevel(float fLevelDB, in Guid pguidEventContext);
    
    // https://learn.microsoft.com/windows/win32/api/endpointvolume/nf-endpointvolume-iaudioendpointvolume-setmastervolumelevelscalar
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetMasterVolumeLevelScalar(float fLevel, in Guid pguidEventContext);
    
    // https://learn.microsoft.com/windows/win32/api/endpointvolume/nf-endpointvolume-iaudioendpointvolume-getmastervolumelevel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMasterVolumeLevel(out float pfLevelDB);
    
    // https://learn.microsoft.com/windows/win32/api/endpointvolume/nf-endpointvolume-iaudioendpointvolume-getmastervolumelevelscalar
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMasterVolumeLevelScalar(out float pfLevel);
    
    // https://learn.microsoft.com/windows/win32/api/endpointvolume/nf-endpointvolume-iaudioendpointvolume-setchannelvolumelevel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetChannelVolumeLevel(uint nChannel, float fLevelDB, in Guid pguidEventContext);
    
    // https://learn.microsoft.com/windows/win32/api/endpointvolume/nf-endpointvolume-iaudioendpointvolume-setchannelvolumelevelscalar
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetChannelVolumeLevelScalar(uint nChannel, float fLevel, in Guid pguidEventContext);
    
    // https://learn.microsoft.com/windows/win32/api/endpointvolume/nf-endpointvolume-iaudioendpointvolume-getchannelvolumelevel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetChannelVolumeLevel(uint nChannel, out float pfLevelDB);
    
    // https://learn.microsoft.com/windows/win32/api/endpointvolume/nf-endpointvolume-iaudioendpointvolume-getchannelvolumelevelscalar
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetChannelVolumeLevelScalar(uint nChannel, out float pfLevel);
    
    // https://learn.microsoft.com/windows/win32/api/endpointvolume/nf-endpointvolume-iaudioendpointvolume-setmute
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetMute(BOOL bMute, in Guid pguidEventContext);
    
    // https://learn.microsoft.com/windows/win32/api/endpointvolume/nf-endpointvolume-iaudioendpointvolume-getmute
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMute(out BOOL pbMute);
    
    // https://learn.microsoft.com/windows/win32/api/endpointvolume/nf-endpointvolume-iaudioendpointvolume-getvolumestepinfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVolumeStepInfo(out uint pnStep, out uint pnStepCount);
    
    // https://learn.microsoft.com/windows/win32/api/endpointvolume/nf-endpointvolume-iaudioendpointvolume-volumestepup
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT VolumeStepUp(in Guid pguidEventContext);
    
    // https://learn.microsoft.com/windows/win32/api/endpointvolume/nf-endpointvolume-iaudioendpointvolume-volumestepdown
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT VolumeStepDown(in Guid pguidEventContext);
    
    // https://learn.microsoft.com/windows/win32/api/endpointvolume/nf-endpointvolume-iaudioendpointvolume-queryhardwaresupport
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT QueryHardwareSupport(out uint pdwHardwareSupportMask);
    
    // https://learn.microsoft.com/windows/win32/api/endpointvolume/nf-endpointvolume-iaudioendpointvolume-getvolumerange
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVolumeRange(out float pflVolumeMindB, out float pflVolumeMaxdB, out float pflVolumeIncrementdB);
}
