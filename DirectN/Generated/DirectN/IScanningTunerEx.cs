#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/tuner/nn-tuner-iscanningtunerex
[GeneratedComInterface, Guid("04bbd195-0e2d-4593-9bd5-4f908bc33cf5")]
public partial interface IScanningTunerEx : IScanningTuner
{
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-iscanningtunerex-getcurrentlocator
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCurrentLocator(in ILocator pILocator);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-iscanningtunerex-performexhaustivescan
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PerformExhaustiveScan(int dwLowerFreq, int dwHigherFreq, VARIANT_BOOL bFineTune, nuint hEvent);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-iscanningtunerex-terminatecurrentscan
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TerminateCurrentScan(out int pcurrentFreq);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-iscanningtunerex-resumecurrentscan
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ResumeCurrentScan(nuint hEvent);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-iscanningtunerex-gettunerscanningcapability
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTunerScanningCapability(out int HardwareAssistedScanning, out int NumStandardsSupported, out Guid BroadcastStandards);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-iscanningtunerex-gettunerstatus
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTunerStatus(out int SecondsLeft, out int CurrentLockType, out int AutoDetect, out int CurrentFreq);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-iscanningtunerex-getcurrenttunerstandardcapability
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCurrentTunerStandardCapability(Guid CurrentBroadcastStandard, out int SettlingTime, out int TvStandardsSupported);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-iscanningtunerex-setscansignaltypefilter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetScanSignalTypeFilter(int ScanModulationTypes, int AnalogVideoStandard);
}
