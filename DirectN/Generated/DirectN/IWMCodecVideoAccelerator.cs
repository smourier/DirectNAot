#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("990641b0-739f-4e94-a808-9888da8f75af")]
public partial interface IWMCodecVideoAccelerator
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT NegotiateConnection(IAMVideoAccelerator pIAMVA, in AM_MEDIA_TYPE pMediaType);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPlayerNotify(IWMPlayerTimestampHook pHook);
}
