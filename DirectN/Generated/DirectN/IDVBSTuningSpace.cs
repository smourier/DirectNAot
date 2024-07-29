#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/tuner/nn-tuner-idvbstuningspace
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("cdf7be60-d954-42fd-a972-78971958e470")]
public partial interface IDVBSTuningSpace : IDVBTuningSpace2
{
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-idvbstuningspace-get_lowoscillator
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_LowOscillator(out int LowOscillator);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-idvbstuningspace-put_lowoscillator
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_LowOscillator(int LowOscillator);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-idvbstuningspace-get_highoscillator
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_HighOscillator(out int HighOscillator);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-idvbstuningspace-put_highoscillator
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_HighOscillator(int HighOscillator);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-idvbstuningspace-get_lnbswitch
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_LNBSwitch(out int LNBSwitch);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-idvbstuningspace-put_lnbswitch
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_LNBSwitch(int LNBSwitch);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-idvbstuningspace-get_inputrange
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_InputRange(out BSTR InputRange);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-idvbstuningspace-put_inputrange
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_InputRange(BSTR InputRange);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-idvbstuningspace-get_spectralinversion
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_SpectralInversion(out SpectralInversion SpectralInversionVal);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-idvbstuningspace-put_spectralinversion
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_SpectralInversion(SpectralInversion SpectralInversionVal);
}
