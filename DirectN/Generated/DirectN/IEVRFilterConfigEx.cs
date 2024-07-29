#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/evr/nn-evr-ievrfilterconfigex
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("aea36028-796d-454f-beee-b48071e24304")]
public partial interface IEVRFilterConfigEx : IEVRFilterConfig
{
    // https://learn.microsoft.com/windows/win32/api/evr/nf-evr-ievrfilterconfigex-setconfigprefs
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetConfigPrefs(uint dwConfigFlags);
    
    // https://learn.microsoft.com/windows/win32/api/evr/nf-evr-ievrfilterconfigex-getconfigprefs
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetConfigPrefs(out uint pdwConfigFlags);
}
