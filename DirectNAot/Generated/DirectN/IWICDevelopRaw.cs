namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wincodec/nn-wincodec-iwicdevelopraw
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("fbec5e44-f7be-4b65-b7f8-c0c81fef026d")]
public partial interface IWICDevelopRaw : IWICBitmapFrameDecode
{
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicdevelopraw-queryrawcapabilitiesinfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT QueryRawCapabilitiesInfo(ref WICRawCapabilitiesInfo pInfo);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicdevelopraw-loadparameterset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT LoadParameterSet(WICRawParameterSet ParameterSet);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicdevelopraw-getcurrentparameterset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetCurrentParameterSet(out IPropertyBag2 ppCurrentParameterSet);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicdevelopraw-setexposurecompensation
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetExposureCompensation(double ev);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicdevelopraw-getexposurecompensation
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetExposureCompensation(out double pEV);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicdevelopraw-setwhitepointrgb
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetWhitePointRGB(uint Red, uint Green, uint Blue);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicdevelopraw-getwhitepointrgb
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetWhitePointRGB(out uint pRed, out uint pGreen, out uint pBlue);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicdevelopraw-setnamedwhitepoint
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetNamedWhitePoint(WICNamedWhitePoint WhitePoint);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicdevelopraw-getnamedwhitepoint
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetNamedWhitePoint(out WICNamedWhitePoint pWhitePoint);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicdevelopraw-setwhitepointkelvin
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetWhitePointKelvin(uint WhitePointKelvin);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicdevelopraw-getwhitepointkelvin
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetWhitePointKelvin(out uint pWhitePointKelvin);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicdevelopraw-getkelvinrangeinfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetKelvinRangeInfo(out uint pMinKelvinTemp, out uint pMaxKelvinTemp, out uint pKelvinTempStepValue);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicdevelopraw-setcontrast
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetContrast(double Contrast);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicdevelopraw-getcontrast
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetContrast(out double pContrast);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicdevelopraw-setgamma
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetGamma(double Gamma);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicdevelopraw-getgamma
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetGamma(out double pGamma);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicdevelopraw-setsharpness
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetSharpness(double Sharpness);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicdevelopraw-getsharpness
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetSharpness(out double pSharpness);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicdevelopraw-setsaturation
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetSaturation(double Saturation);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicdevelopraw-getsaturation
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetSaturation(out double pSaturation);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicdevelopraw-settint
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetTint(double Tint);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicdevelopraw-gettint
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetTint(out double pTint);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicdevelopraw-setnoisereduction
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetNoiseReduction(double NoiseReduction);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicdevelopraw-getnoisereduction
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetNoiseReduction(out double pNoiseReduction);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicdevelopraw-setdestinationcolorcontext
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetDestinationColorContext(IWICColorContext pColorContext);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicdevelopraw-settonecurve
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetToneCurve(uint cbToneCurveSize, in WICRawToneCurve pToneCurve);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicdevelopraw-gettonecurve
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetToneCurve(uint cbToneCurveBufferSize, nint/* nint */ pToneCurve, nint/* nint */ pcbActualToneCurveBufferSize);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicdevelopraw-setrotation
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetRotation(double Rotation);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicdevelopraw-getrotation
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetRotation(out double pRotation);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicdevelopraw-setrendermode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetRenderMode(WICRawRenderMode RenderMode);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicdevelopraw-getrendermode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetRenderMode(out WICRawRenderMode pRenderMode);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicdevelopraw-setnotificationcallback
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetNotificationCallback(IWICDevelopRawNotificationCallback pCallback);
}
