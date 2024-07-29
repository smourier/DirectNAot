#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/tuner/nn-tuner-iesevent
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("1f0e5357-af43-44e6-8547-654c645145d2")]
public partial interface IESEvent
{
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-iesevent-geteventid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetEventId(out uint pdwEventId);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-iesevent-geteventtype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetEventType(out Guid pguidEventType);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-iesevent-setcompletionstatus
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetCompletionStatus(uint dwResult);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-iesevent-getdata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetData(out nint pbData);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-iesevent-getstringdata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStringData(out BSTR pbstrData);
}
