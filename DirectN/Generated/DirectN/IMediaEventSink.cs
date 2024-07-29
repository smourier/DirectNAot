#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-imediaeventsink
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("56a868a2-0ad4-11ce-b03a-0020af0ba770")]
public partial interface IMediaEventSink
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-imediaeventsink-notify
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Notify(int EventCode, nint EventParam1, nint EventParam2);
}
