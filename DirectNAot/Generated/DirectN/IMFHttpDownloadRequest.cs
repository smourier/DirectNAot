#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfhttpdownloadrequest
[SupportedOSPlatform("windows10.0.15063")]
[GeneratedComInterface, Guid("f779fddf-26e7-4270-8a8b-b983d1859de0")]
public partial interface IMFHttpDownloadRequest
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfhttpdownloadrequest-addheader
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddHeader(PWSTR szHeader);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfhttpdownloadrequest-beginsendrequest
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT BeginSendRequest(nint /* optional byte* */ pbPayload, uint cbPayload, IMFAsyncCallback pCallback, nint punkState);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfhttpdownloadrequest-endsendrequest
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EndSendRequest(IMFAsyncResult pResult);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfhttpdownloadrequest-beginreceiveresponse
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT BeginReceiveResponse(IMFAsyncCallback pCallback, nint punkState);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfhttpdownloadrequest-endreceiveresponse
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EndReceiveResponse(IMFAsyncResult pResult);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfhttpdownloadrequest-beginreadpayload
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT BeginReadPayload(nint /* byte array */ pb, uint cb, IMFAsyncCallback pCallback, nint punkState);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfhttpdownloadrequest-endreadpayload
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EndReadPayload(IMFAsyncResult pResult, out ulong pqwOffset, out uint pcbRead);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfhttpdownloadrequest-queryheader
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT QueryHeader(PWSTR szHeaderName, uint dwIndex, out PWSTR ppszHeaderValue);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfhttpdownloadrequest-geturl
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetURL(out PWSTR ppszURL);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfhttpdownloadrequest-hasnullsourceorigin
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT HasNullSourceOrigin([MarshalAs(UnmanagedType.U4)] out bool pfNullSourceOrigin);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfhttpdownloadrequest-gettimeseekresult
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTimeSeekResult(out ulong pqwStartTime, out ulong pqwStopTime, out ulong pqwDuration);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfhttpdownloadrequest-gethttpstatus
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetHttpStatus(out uint pdwHttpStatus);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfhttpdownloadrequest-getatendofpayload
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAtEndOfPayload([MarshalAs(UnmanagedType.U4)] out bool pfAtEndOfPayload);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfhttpdownloadrequest-gettotallength
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTotalLength(out ulong pqwTotalLength);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfhttpdownloadrequest-getrangeendoffset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRangeEndOffset(out ulong pqwRangeEnd);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfhttpdownloadrequest-close
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Close();
}
