#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/vidcap/nn-vidcap-ivideoprocamp
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("4050560e-42a7-413a-85c2-09269a2d0f44")]
public partial interface IVideoProcAmp
{
    // https://learn.microsoft.com/windows/win32/api/vidcap/nf-vidcap-ivideoprocamp-get_backlightcompensation
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_BacklightCompensation(out int pValue, out int pFlags);
    
    // https://learn.microsoft.com/windows/win32/api/vidcap/nf-vidcap-ivideoprocamp-put_backlightcompensation
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_BacklightCompensation(int Value, int Flags);
    
    // https://learn.microsoft.com/windows/win32/api/vidcap/nf-vidcap-ivideoprocamp-getrange_backlightcompensation
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT getRange_BacklightCompensation(out int pMin, out int pMax, out int pSteppingDelta, out int pDefault, out int pCapsFlag);
    
    // https://learn.microsoft.com/windows/win32/api/vidcap/nf-vidcap-ivideoprocamp-get_brightness
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Brightness(out int pValue, out int pFlags);
    
    // https://learn.microsoft.com/windows/win32/api/vidcap/nf-vidcap-ivideoprocamp-put_brightness
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Brightness(int Value, int Flags);
    
    // https://learn.microsoft.com/windows/win32/api/vidcap/nf-vidcap-ivideoprocamp-getrange_brightness
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT getRange_Brightness(out int pMin, out int pMax, out int pSteppingDelta, out int pDefault, out int pCapsFlag);
    
    // https://learn.microsoft.com/windows/win32/api/vidcap/nf-vidcap-ivideoprocamp-get_colorenable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ColorEnable(out int pValue, out int pFlags);
    
    // https://learn.microsoft.com/windows/win32/api/vidcap/nf-vidcap-ivideoprocamp-put_colorenable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_ColorEnable(int Value, int Flags);
    
    // https://learn.microsoft.com/windows/win32/api/vidcap/nf-vidcap-ivideoprocamp-getrange_colorenable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT getRange_ColorEnable(out int pMin, out int pMax, out int pSteppingDelta, out int pDefault, out int pCapsFlag);
    
    // https://learn.microsoft.com/windows/win32/api/vidcap/nf-vidcap-ivideoprocamp-get_contrast
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Contrast(out int pValue, out int pFlags);
    
    // https://learn.microsoft.com/windows/win32/api/vidcap/nf-vidcap-ivideoprocamp-put_contrast
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Contrast(int Value, int Flags);
    
    // https://learn.microsoft.com/windows/win32/api/vidcap/nf-vidcap-ivideoprocamp-getrange_contrast
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT getRange_Contrast(out int pMin, out int pMax, out int pSteppingDelta, out int pDefault, out int pCapsFlag);
    
    // https://learn.microsoft.com/windows/win32/api/vidcap/nf-vidcap-ivideoprocamp-get_gamma
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Gamma(out int pValue, out int pFlags);
    
    // https://learn.microsoft.com/windows/win32/api/vidcap/nf-vidcap-ivideoprocamp-put_gamma
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Gamma(int Value, int Flags);
    
    // https://learn.microsoft.com/windows/win32/api/vidcap/nf-vidcap-ivideoprocamp-getrange_gamma
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT getRange_Gamma(out int pMin, out int pMax, out int pSteppingDelta, out int pDefault, out int pCapsFlag);
    
    // https://learn.microsoft.com/windows/win32/api/vidcap/nf-vidcap-ivideoprocamp-get_saturation
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Saturation(out int pValue, out int pFlags);
    
    // https://learn.microsoft.com/windows/win32/api/vidcap/nf-vidcap-ivideoprocamp-put_saturation
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Saturation(int Value, int Flags);
    
    // https://learn.microsoft.com/windows/win32/api/vidcap/nf-vidcap-ivideoprocamp-getrange_saturation
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT getRange_Saturation(out int pMin, out int pMax, out int pSteppingDelta, out int pDefault, out int pCapsFlag);
    
    // https://learn.microsoft.com/windows/win32/api/vidcap/nf-vidcap-ivideoprocamp-get_sharpness
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Sharpness(out int pValue, out int pFlags);
    
    // https://learn.microsoft.com/windows/win32/api/vidcap/nf-vidcap-ivideoprocamp-put_sharpness
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Sharpness(int Value, int Flags);
    
    // https://learn.microsoft.com/windows/win32/api/vidcap/nf-vidcap-ivideoprocamp-getrange_sharpness
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT getRange_Sharpness(out int pMin, out int pMax, out int pSteppingDelta, out int pDefault, out int pCapsFlag);
    
    // https://learn.microsoft.com/windows/win32/api/vidcap/nf-vidcap-ivideoprocamp-get_whitebalance
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_WhiteBalance(out int pValue, out int pFlags);
    
    // https://learn.microsoft.com/windows/win32/api/vidcap/nf-vidcap-ivideoprocamp-put_whitebalance
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_WhiteBalance(int Value, int Flags);
    
    // https://learn.microsoft.com/windows/win32/api/vidcap/nf-vidcap-ivideoprocamp-getrange_whitebalance
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT getRange_WhiteBalance(out int pMin, out int pMax, out int pSteppingDelta, out int pDefault, out int pCapsFlag);
    
    // https://learn.microsoft.com/windows/win32/api/vidcap/nf-vidcap-ivideoprocamp-get_gain
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Gain(out int pValue, out int pFlags);
    
    // https://learn.microsoft.com/windows/win32/api/vidcap/nf-vidcap-ivideoprocamp-put_gain
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Gain(int Value, int Flags);
    
    // https://learn.microsoft.com/windows/win32/api/vidcap/nf-vidcap-ivideoprocamp-getrange_gain
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT getRange_Gain(out int pMin, out int pMax, out int pSteppingDelta, out int pDefault, out int pCapsFlag);
    
    // https://learn.microsoft.com/windows/win32/api/vidcap/nf-vidcap-ivideoprocamp-get_hue
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Hue(out int pValue, out int pFlags);
    
    // https://learn.microsoft.com/windows/win32/api/vidcap/nf-vidcap-ivideoprocamp-put_hue
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Hue(int Value, int Flags);
    
    // https://learn.microsoft.com/windows/win32/api/vidcap/nf-vidcap-ivideoprocamp-getrange_hue
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT getRange_Hue(out int pMin, out int pMax, out int pSteppingDelta, out int pDefault, out int pCapsFlag);
    
    // https://learn.microsoft.com/windows/win32/api/vidcap/nf-vidcap-ivideoprocamp-get_digitalmultiplier
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_DigitalMultiplier(out int pValue, out int pFlags);
    
    // https://learn.microsoft.com/windows/win32/api/vidcap/nf-vidcap-ivideoprocamp-put_digitalmultiplier
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_DigitalMultiplier(int Value, int Flags);
    
    // https://learn.microsoft.com/windows/win32/api/vidcap/nf-vidcap-ivideoprocamp-getrange_digitalmultiplier
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT getRange_DigitalMultiplier(out int pMin, out int pMax, out int pSteppingDelta, out int pDefault, out int pCapsFlag);
    
    // https://learn.microsoft.com/windows/win32/api/vidcap/nf-vidcap-ivideoprocamp-get_powerlinefrequency
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_PowerlineFrequency(out int pValue, out int pFlags);
    
    // https://learn.microsoft.com/windows/win32/api/vidcap/nf-vidcap-ivideoprocamp-put_powerlinefrequency
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_PowerlineFrequency(int Value, int Flags);
    
    // https://learn.microsoft.com/windows/win32/api/vidcap/nf-vidcap-ivideoprocamp-getrange_powerlinefrequency
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT getRange_PowerlineFrequency(out int pMin, out int pMax, out int pSteppingDelta, out int pDefault, out int pCapsFlag);
    
    // https://learn.microsoft.com/windows/win32/api/vidcap/nf-vidcap-ivideoprocamp-get_whitebalancecomponent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_WhiteBalanceComponent(out int pValue1, out int pValue2, ref int pFlags);
    
    // https://learn.microsoft.com/windows/win32/api/vidcap/nf-vidcap-ivideoprocamp-put_whitebalancecomponent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_WhiteBalanceComponent(int Value1, int Value2, int Flags);
    
    // https://learn.microsoft.com/windows/win32/api/vidcap/nf-vidcap-ivideoprocamp-getrange_whitebalancecomponent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT getRange_WhiteBalanceComponent(out int pMin, out int pMax, out int pSteppingDelta, out int pDefault, ref int pCapsFlag);
}
