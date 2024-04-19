namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/sbe/nn-sbe-isbe2globalevent
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("caede759-b6b1-11db-a578-0018f3fa24c6")]
public partial interface ISBE2GlobalEvent
{
    // https://learn.microsoft.com/windows/win32/api/sbe/nf-sbe-isbe2globalevent-getevent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetEvent(in Guid idEvt, uint param1, uint param2, uint param3, uint param4, [MarshalAs(UnmanagedType.U4)] out bool pSpanning, ref uint pcb, nint /* byte array */ pb);
}
