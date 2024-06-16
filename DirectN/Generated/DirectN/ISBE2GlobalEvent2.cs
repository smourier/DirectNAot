#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/sbe/nn-sbe-isbe2globalevent2
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("6d8309bf-00fe-4506-8b03-f8c65b5c9b39")]
public partial interface ISBE2GlobalEvent2 : ISBE2GlobalEvent
{
    // https://learn.microsoft.com/windows/win32/api/sbe/nf-sbe-isbe2globalevent2-geteventex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetEventEx(in Guid idEvt, uint param1, uint param2, uint param3, uint param4, out BOOL pSpanning, ref uint pcb, nint /* byte array */ pb, out long pStreamTime);
}
