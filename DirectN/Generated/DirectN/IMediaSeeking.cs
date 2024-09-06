#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-imediaseeking
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("36b73880-c2c8-11cf-8b46-00805f6cef60")]
public partial interface IMediaSeeking
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-imediaseeking-getcapabilities
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCapabilities(out uint pCapabilities);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-imediaseeking-checkcapabilities
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CheckCapabilities(ref uint pCapabilities);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-imediaseeking-isformatsupported
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsFormatSupported(in Guid pFormat);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-imediaseeking-querypreferredformat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT QueryPreferredFormat(out Guid pFormat);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-imediaseeking-gettimeformat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTimeFormat(out Guid pFormat);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-imediaseeking-isusingtimeformat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsUsingTimeFormat(in Guid pFormat);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-imediaseeking-settimeformat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetTimeFormat(in Guid pFormat);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-imediaseeking-getduration
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDuration(out long pDuration);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-imediaseeking-getstopposition
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStopPosition(out long pStop);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-imediaseeking-getcurrentposition
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCurrentPosition(out long pCurrent);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-imediaseeking-converttimeformat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ConvertTimeFormat(out long pTarget, nint /* optional Guid* */ pTargetFormat, long Source, nint /* optional Guid* */ pSourceFormat);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-imediaseeking-setpositions
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPositions(nint /* optional long* */ pCurrent, uint dwCurrentFlags, nint /* optional long* */ pStop, uint dwStopFlags);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-imediaseeking-getpositions
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPositions(nint /* optional long* */ pCurrent, nint /* optional long* */ pStop);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-imediaseeking-getavailable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAvailable(nint /* optional long* */ pEarliest, nint /* optional long* */ pLatest);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-imediaseeking-setrate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetRate(double dRate);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-imediaseeking-getrate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRate(out double pdRate);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-imediaseeking-getpreroll
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPreroll(out long pllPreroll);
}
