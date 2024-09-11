#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/amstream/nn-amstream-imediastreamfilter
[GeneratedComInterface, Guid("bebe595e-9a6f-11d0-8fde-00c04fd9189d")]
public partial interface IMediaStreamFilter : IBaseFilter
{
    // https://learn.microsoft.com/windows/win32/api/amstream/nf-amstream-imediastreamfilter-addmediastream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddMediaStream([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IAMMediaStream>))] IAMMediaStream pAMMediaStream);
    
    // https://learn.microsoft.com/windows/win32/api/amstream/nf-amstream-imediastreamfilter-getmediastream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMediaStream(in Guid idPurpose, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMediaStream>))] out IMediaStream ppMediaStream);
    
    // https://learn.microsoft.com/windows/win32/api/amstream/nf-amstream-imediastreamfilter-enummediastreams
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumMediaStreams(int Index, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMediaStream>))] out IMediaStream ppMediaStream);
    
    // https://learn.microsoft.com/windows/win32/api/amstream/nf-amstream-imediastreamfilter-supportseeking
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SupportSeeking(BOOL bRenderer);
    
    // https://learn.microsoft.com/windows/win32/api/amstream/nf-amstream-imediastreamfilter-referencetimetostreamtime
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ReferenceTimeToStreamTime(ref long pTime);
    
    // https://learn.microsoft.com/windows/win32/api/amstream/nf-amstream-imediastreamfilter-getcurrentstreamtime
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCurrentStreamTime(out long pCurrentStreamTime);
    
    // https://learn.microsoft.com/windows/win32/api/amstream/nf-amstream-imediastreamfilter-waituntil
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT WaitUntil(long WaitStreamTime);
    
    // https://learn.microsoft.com/windows/win32/api/amstream/nf-amstream-imediastreamfilter-flush
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Flush(BOOL bCancelEOS);
    
    // https://learn.microsoft.com/windows/win32/api/amstream/nf-amstream-imediastreamfilter-endofstream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EndOfStream();
}
