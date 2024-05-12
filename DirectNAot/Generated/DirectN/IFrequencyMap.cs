#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/bdaiface/nn-bdaiface-ifrequencymap
[GeneratedComInterface, Guid("06fb45c1-693c-4ea7-b79f-7a6a54d8def2")]
public partial interface IFrequencyMap
{
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ifrequencymap-get_frequencymapping
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_FrequencyMapping(out uint ulCount, out nint ppulList);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ifrequencymap-put_frequencymapping
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_FrequencyMapping(uint ulCount, [In][MarshalUsing(CountElementName = nameof(ulCount))] uint[] pList);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ifrequencymap-get_countrycode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_CountryCode(out uint pulCountryCode);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ifrequencymap-put_countrycode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_CountryCode(uint ulCountryCode);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ifrequencymap-get_defaultfrequencymapping
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_DefaultFrequencyMapping(uint ulCountryCode, out uint pulCount, out nint ppulList);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ifrequencymap-get_countrycodelist
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_CountryCodeList(out uint pulCount, out nint ppulList);
}
