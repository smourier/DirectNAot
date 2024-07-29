#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/tuner/nn-tuner-ianalogradiotuningspace2
[GeneratedComInterface, Guid("39dd45da-2da8-46ba-8a8a-87e2b73d983a")]
public partial interface IAnalogRadioTuningSpace2 : IAnalogRadioTuningSpace
{
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ianalogradiotuningspace2-get_countrycode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_CountryCode(out int CountryCodeVal);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ianalogradiotuningspace2-put_countrycode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_CountryCode(int NewCountryCodeVal);
}
