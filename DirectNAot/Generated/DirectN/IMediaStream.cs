#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mmstream/nn-mmstream-imediastream
[GeneratedComInterface, Guid("b502d1bd-9a57-11d0-8fde-00c04fd9189d")]
public partial interface IMediaStream
{
    // https://learn.microsoft.com/windows/win32/api/mmstream/nf-mmstream-imediastream-getmultimediastream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMultiMediaStream(out IMultiMediaStream ppMultiMediaStream);
    
    // https://learn.microsoft.com/windows/win32/api/mmstream/nf-mmstream-imediastream-getinformation
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetInformation(out Guid pPurposeId, out STREAM_TYPE pType);
    
    // https://learn.microsoft.com/windows/win32/api/mmstream/nf-mmstream-imediastream-setsameformat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSameFormat(IMediaStream pStreamThatHasDesiredFormat, uint dwFlags);
    
    // https://learn.microsoft.com/windows/win32/api/mmstream/nf-mmstream-imediastream-allocatesample
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AllocateSample(uint dwFlags, out IStreamSample ppSample);
    
    // https://learn.microsoft.com/windows/win32/api/mmstream/nf-mmstream-imediastream-createsharedsample
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateSharedSample(IStreamSample pExistingSample, uint dwFlags, out IStreamSample ppNewSample);
    
    // https://learn.microsoft.com/windows/win32/api/mmstream/nf-mmstream-imediastream-sendendofstream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SendEndOfStream(uint dwFlags);
}
