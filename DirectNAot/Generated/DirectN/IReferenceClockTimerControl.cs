namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-ireferenceclocktimercontrol
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("ebec459c-2eca-4d42-a8af-30df557614b8")]
public partial interface IReferenceClockTimerControl
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ireferenceclocktimercontrol-setdefaulttimerresolution
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDefaultTimerResolution(long timerResolution);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ireferenceclocktimercontrol-getdefaulttimerresolution
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDefaultTimerResolution(out long pTimerResolution);
}
