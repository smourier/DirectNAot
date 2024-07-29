#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfqualityadviselimits
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("dfcd8e4d-30b5-4567-acaa-8eb5b7853dc9")]
public partial interface IMFQualityAdviseLimits
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfqualityadviselimits-getmaximumdropmode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMaximumDropMode(out MF_QUALITY_DROP_MODE peDropMode);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfqualityadviselimits-getminimumqualitylevel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMinimumQualityLevel(out MF_QUALITY_LEVEL peQualityLevel);
}
