namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dcompanimation/nn-dcompanimation-idcompositionanimation
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("cbfd91d9-51b2-45e4-b3de-d19ccfb863c5")]
public partial interface IDCompositionAnimation
{
    // https://learn.microsoft.com/windows/win32/api/dcompanimation/nf-dcompanimation-idcompositionanimation-reset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Reset();
    
    // https://learn.microsoft.com/windows/win32/api/dcompanimation/nf-dcompanimation-idcompositionanimation-setabsolutebegintime
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAbsoluteBeginTime(long beginTime);
    
    // https://learn.microsoft.com/windows/win32/api/dcompanimation/nf-dcompanimation-idcompositionanimation-addcubic
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddCubic(double beginOffset, float constantCoefficient, float linearCoefficient, float quadraticCoefficient, float cubicCoefficient);
    
    // https://learn.microsoft.com/windows/win32/api/dcompanimation/nf-dcompanimation-idcompositionanimation-addsinusoidal
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddSinusoidal(double beginOffset, float bias, float amplitude, float frequency, float phase);
    
    // https://learn.microsoft.com/windows/win32/api/dcompanimation/nf-dcompanimation-idcompositionanimation-addrepeat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddRepeat(double beginOffset, double durationToRepeat);
    
    // https://learn.microsoft.com/windows/win32/api/dcompanimation/nf-dcompanimation-idcompositionanimation-end
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT End(double endOffset, float endValue);
}
