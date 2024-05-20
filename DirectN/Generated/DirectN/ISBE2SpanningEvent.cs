#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/sbe/nn-sbe-isbe2spanningevent
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("caede760-b6b1-11db-a578-0018f3fa24c6")]
public partial interface ISBE2SpanningEvent
{
    // https://learn.microsoft.com/windows/win32/api/sbe/nf-sbe-isbe2spanningevent-getevent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetEvent(in Guid idEvt, uint streamId, ref uint pcb, nint /* byte array */ pb);
}
