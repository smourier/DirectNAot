#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/effects/nn-effects-iwmpeffects
[GeneratedComInterface, Guid("d3984c13-c3cb-48e2-8be5-5168340b4f35")]
public partial interface IWMPEffects
{
    // https://learn.microsoft.com/windows/win32/api/effects/nf-effects-iwmpeffects-render
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Render(ref TimedLevel pLevels, HDC hdc, ref RECT prc);
    
    // https://learn.microsoft.com/windows/win32/api/effects/nf-effects-iwmpeffects-mediainfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT MediaInfo(int lChannelCount, int lSampleRate, BSTR bstrTitle);
    
    // https://learn.microsoft.com/windows/win32/api/effects/nf-effects-iwmpeffects-getcapabilities
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCapabilities(ref uint pdwCapabilities);
    
    // https://learn.microsoft.com/windows/win32/api/effects/nf-effects-iwmpeffects-gettitle
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTitle(ref BSTR bstrTitle);
    
    // https://learn.microsoft.com/windows/win32/api/effects/nf-effects-iwmpeffects-getpresettitle
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPresetTitle(int nPreset, ref BSTR bstrPresetTitle);
    
    // https://learn.microsoft.com/windows/win32/api/effects/nf-effects-iwmpeffects-getpresetcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPresetCount(ref int pnPresetCount);
    
    // https://learn.microsoft.com/windows/win32/api/effects/nf-effects-iwmpeffects-setcurrentpreset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetCurrentPreset(int nPreset);
    
    // https://learn.microsoft.com/windows/win32/api/effects/nf-effects-iwmpeffects-getcurrentpreset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCurrentPreset(ref int pnPreset);
    
    // https://learn.microsoft.com/windows/win32/api/effects/nf-effects-iwmpeffects-displaypropertypage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DisplayPropertyPage(HWND hwndOwner);
    
    // https://learn.microsoft.com/windows/win32/api/effects/nf-effects-iwmpeffects-gofullscreen
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GoFullscreen(BOOL fFullScreen);
    
    // https://learn.microsoft.com/windows/win32/api/effects/nf-effects-iwmpeffects-renderfullscreen
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RenderFullScreen(ref TimedLevel pLevels);
}
