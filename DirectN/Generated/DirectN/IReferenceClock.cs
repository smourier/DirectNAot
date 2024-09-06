#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/wmformat/ireferenceclock
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("56a86897-0ad4-11ce-b03a-0020af0ba770")]
public partial interface IReferenceClock
{
    // https://learn.microsoft.com/windows/win32/wmformat/ireferenceclock-gettime
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTime(out long pTime);
    
    // https://learn.microsoft.com/windows/win32/wmformat/ireferenceclock-advisetime
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AdviseTime(long baseTime, long streamTime, HANDLE hEvent, out nuint pdwAdviseCookie);
    
    // https://learn.microsoft.com/windows/win32/wmformat/ireferenceclock-adviseperiodic
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AdvisePeriodic(long startTime, long periodTime, HANDLE hSemaphore, out nuint pdwAdviseCookie);
    
    // https://learn.microsoft.com/windows/win32/wmformat/ireferenceclock-unadvise
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Unadvise(nuint dwAdviseCookie);
}
