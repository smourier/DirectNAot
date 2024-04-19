namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/tuner/nn-tuner-idvbslocator2
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("6044634a-1733-4f99-b982-5fb12afce4f0")]
public partial interface IDVBSLocator2 : IDVBSLocator
{
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-idvbslocator2-get_diseqlnbsource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_DiseqLNBSource(out LNB_Source DiseqLNBSourceVal);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-idvbslocator2-put_diseqlnbsource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_DiseqLNBSource(LNB_Source DiseqLNBSourceVal);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-idvbslocator2-get_localoscillatoroverridelow
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_LocalOscillatorOverrideLow(out int LocalOscillatorOverrideLowVal);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-idvbslocator2-put_localoscillatoroverridelow
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_LocalOscillatorOverrideLow(int LocalOscillatorOverrideLowVal);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-idvbslocator2-get_localoscillatoroverridehigh
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_LocalOscillatorOverrideHigh(out int LocalOscillatorOverrideHighVal);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-idvbslocator2-put_localoscillatoroverridehigh
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_LocalOscillatorOverrideHigh(int LocalOscillatorOverrideHighVal);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-idvbslocator2-get_locallnbswitchoverride
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_LocalLNBSwitchOverride(out int LocalLNBSwitchOverrideVal);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-idvbslocator2-put_locallnbswitchoverride
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_LocalLNBSwitchOverride(int LocalLNBSwitchOverrideVal);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-idvbslocator2-get_localspectralinversionoverride
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_LocalSpectralInversionOverride(out SpectralInversion LocalSpectralInversionOverrideVal);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-idvbslocator2-put_localspectralinversionoverride
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_LocalSpectralInversionOverride(SpectralInversion LocalSpectralInversionOverrideVal);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-idvbslocator2-get_signalrolloff
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_SignalRollOff(out RollOff RollOffVal);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-idvbslocator2-put_signalrolloff
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_SignalRollOff(RollOff RollOffVal);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-idvbslocator2-get_signalpilot
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_SignalPilot(out Pilot PilotVal);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-idvbslocator2-put_signalpilot
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_SignalPilot(Pilot PilotVal);
}
