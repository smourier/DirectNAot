#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mpeg2data/nn-mpeg2data-impeg2stream
[GeneratedComInterface, Guid("400cc286-32a0-4ce4-9041-39571125a635")]
public partial interface IMpeg2Stream
{
    // https://learn.microsoft.com/windows/win32/api/mpeg2data/nf-mpeg2data-impeg2stream-initialize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Initialize(MPEG_REQUEST_TYPE requestType, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMpeg2Data>))] IMpeg2Data pMpeg2Data, in MPEG_CONTEXT pContext, ushort pid, byte tid, in MPEG2_FILTER pFilter, HANDLE hDataReadyEvent);
    
    // https://learn.microsoft.com/windows/win32/api/mpeg2data/nf-mpeg2data-impeg2stream-supplydatabuffer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SupplyDataBuffer(in MPEG_STREAM_BUFFER pStreamBuffer);
}
