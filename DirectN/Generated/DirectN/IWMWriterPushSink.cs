#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/nn-wmsdkidl-iwmwriterpushsink
[GeneratedComInterface, Guid("dc10e6a5-072c-467d-bf57-6330a9dde12a")]
public partial interface IWMWriterPushSink : IWMWriterSink
{
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmwriterpushsink-connect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Connect(PWSTR pwszURL, PWSTR pwszTemplateURL, BOOL fAutoDestroy);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmwriterpushsink-disconnect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Disconnect();
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmwriterpushsink-endsession
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EndSession();
}
