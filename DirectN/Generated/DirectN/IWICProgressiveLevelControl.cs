#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wincodec/nn-wincodec-iwicprogressivelevelcontrol
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("daac296f-7aa5-4dbf-8d15-225c5976f891")]
public partial interface IWICProgressiveLevelControl
{
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicprogressivelevelcontrol-getlevelcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLevelCount(out uint pcLevels);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicprogressivelevelcontrol-getcurrentlevel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCurrentLevel(out uint pnLevel);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicprogressivelevelcontrol-setcurrentlevel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetCurrentLevel(uint nLevel);
}
