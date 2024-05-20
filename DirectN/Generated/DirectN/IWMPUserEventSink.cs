#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmpservices/nn-wmpservices-iwmpusereventsink
[GeneratedComInterface, Guid("cfccfa72-c343-48c3-a2de-b7a4402e39f2")]
public partial interface IWMPUserEventSink
{
    // https://learn.microsoft.com/windows/win32/api/wmpservices/nf-wmpservices-iwmpusereventsink-notifyuserevent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT NotifyUserEvent(int EventCode);
}
