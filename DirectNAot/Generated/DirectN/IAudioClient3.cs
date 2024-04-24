namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/audioclient/nn-audioclient-iaudioclient3
[SupportedOSPlatform("windows10.0.10240")]
[GeneratedComInterface, Guid("7ed4ee07-8e67-4cd4-8c1a-2b7a5987ad42")]
public partial interface IAudioClient3 : IAudioClient2
{
    // https://learn.microsoft.com/windows/win32/api/audioclient/nf-audioclient-iaudioclient3-getsharedmodeengineperiod
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSharedModeEnginePeriod(in WAVEFORMATEX pFormat, out uint pDefaultPeriodInFrames, out uint pFundamentalPeriodInFrames, out uint pMinPeriodInFrames, out uint pMaxPeriodInFrames);
    
    // https://learn.microsoft.com/windows/win32/api/audioclient/nf-audioclient-iaudioclient3-getcurrentsharedmodeengineperiod
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCurrentSharedModeEnginePeriod(out nint ppFormat, out uint pCurrentPeriodInFrames);
    
    // https://learn.microsoft.com/windows/win32/api/audioclient/nf-audioclient-iaudioclient3-initializesharedaudiostream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InitializeSharedAudioStream(uint StreamFlags, uint PeriodInFrames, in WAVEFORMATEX pFormat, nint /* optional Guid* */ AudioSessionGuid);
}
