#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mmstream/nn-mmstream-imultimediastream
[GeneratedComInterface, Guid("b502d1bc-9a57-11d0-8fde-00c04fd9189d")]
public partial interface IMultiMediaStream
{
    // https://learn.microsoft.com/windows/win32/api/mmstream/nf-mmstream-imultimediastream-getinformation
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetInformation(out MMSSF_GET_INFORMATION_FLAGS pdwFlags, out STREAM_TYPE pStreamType);
    
    // https://learn.microsoft.com/windows/win32/api/mmstream/nf-mmstream-imultimediastream-getmediastream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMediaStream(in Guid idPurpose, out IMediaStream ppMediaStream);
    
    // https://learn.microsoft.com/windows/win32/api/mmstream/nf-mmstream-imultimediastream-enummediastreams
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumMediaStreams(int Index, out IMediaStream ppMediaStream);
    
    // https://learn.microsoft.com/windows/win32/api/mmstream/nf-mmstream-imultimediastream-getstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetState(out STREAM_STATE pCurrentState);
    
    // https://learn.microsoft.com/windows/win32/api/mmstream/nf-mmstream-imultimediastream-setstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetState(STREAM_STATE NewState);
    
    // https://learn.microsoft.com/windows/win32/api/mmstream/nf-mmstream-imultimediastream-gettime
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTime(out long pCurrentTime);
    
    // https://learn.microsoft.com/windows/win32/api/mmstream/nf-mmstream-imultimediastream-getduration
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDuration(out long pDuration);
    
    // https://learn.microsoft.com/windows/win32/api/mmstream/nf-mmstream-imultimediastream-seek
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Seek(long SeekTime);
    
    // https://learn.microsoft.com/windows/win32/api/mmstream/nf-mmstream-imultimediastream-getendofstreameventhandle
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetEndOfStreamEventHandle(out HANDLE phEOS);
}
