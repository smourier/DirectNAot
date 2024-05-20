#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/tuner/nn-tuner-iesisdbcasresponseevent
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("2017cb03-dc0f-4c24-83ca-36307b2cd19f")]
public partial interface IESIsdbCasResponseEvent : IESEvent
{
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-iesisdbcasresponseevent-getrequestid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRequestId(out uint pRequestId);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-iesisdbcasresponseevent-getstatus
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStatus(out uint pStatus);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-iesisdbcasresponseevent-getdatalength
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDataLength(out uint pRequestLength);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-iesisdbcasresponseevent-getresponsedata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetResponseData(out nint pbData);
}
