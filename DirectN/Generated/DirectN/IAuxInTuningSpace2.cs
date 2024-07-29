#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/tuner/nn-tuner-iauxintuningspace2
[GeneratedComInterface, Guid("b10931ed-8bfe-4ab0-9dce-e469c29a9729")]
public partial interface IAuxInTuningSpace2 : IAuxInTuningSpace
{
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-iauxintuningspace2-get_countrycode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_CountryCode(out int CountryCodeVal);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-iauxintuningspace2-put_countrycode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_CountryCode(int NewCountryCodeVal);
}
