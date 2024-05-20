#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mmstream/nn-mmstream-istreamsample
[GeneratedComInterface, Guid("b502d1be-9a57-11d0-8fde-00c04fd9189d")]
public partial interface IStreamSample
{
    // https://learn.microsoft.com/windows/win32/api/mmstream/nf-mmstream-istreamsample-getmediastream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMediaStream(in IMediaStream ppMediaStream);
    
    // https://learn.microsoft.com/windows/win32/api/mmstream/nf-mmstream-istreamsample-getsampletimes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSampleTimes(out long pStartTime, out long pEndTime, out long pCurrentTime);
    
    // https://learn.microsoft.com/windows/win32/api/mmstream/nf-mmstream-istreamsample-setsampletimes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSampleTimes(in long pStartTime, in long pEndTime);
    
    // https://learn.microsoft.com/windows/win32/api/mmstream/nf-mmstream-istreamsample-update
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Update(uint dwFlags, HANDLE hEvent, PAPCFUNC pfnAPC, nuint dwAPCData);
    
    // https://learn.microsoft.com/windows/win32/api/mmstream/nf-mmstream-istreamsample-completionstatus
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CompletionStatus(uint dwFlags, uint dwMilliseconds);
}
