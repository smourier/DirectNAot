#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/amstream/nn-amstream-iammediastream
[GeneratedComInterface, Guid("bebe595d-9a6f-11d0-8fde-00c04fd9189d")]
public partial interface IAMMediaStream : IMediaStream
{
    // https://learn.microsoft.com/windows/win32/api/amstream/nf-amstream-iammediastream-initialize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Initialize(nint pSourceObject, uint dwFlags, in Guid PurposeId, STREAM_TYPE StreamType);
    
    // https://learn.microsoft.com/windows/win32/api/amstream/nf-amstream-iammediastream-setstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetState(FILTER_STATE State);
    
    // https://learn.microsoft.com/windows/win32/api/amstream/nf-amstream-iammediastream-joinammultimediastream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT JoinAMMultiMediaStream([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IAMMultiMediaStream>))] IAMMultiMediaStream pAMMultiMediaStream);
    
    // https://learn.microsoft.com/windows/win32/api/amstream/nf-amstream-iammediastream-joinfilter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT JoinFilter([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMediaStreamFilter>))] IMediaStreamFilter pMediaStreamFilter);
    
    // https://learn.microsoft.com/windows/win32/api/amstream/nf-amstream-iammediastream-joinfiltergraph
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT JoinFilterGraph([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IFilterGraph>))] IFilterGraph pFilterGraph);
}
