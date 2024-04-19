namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-ioverlaynotify2
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("680efa10-d535-11d1-87c8-00a0c9223196")]
public partial interface IOverlayNotify2 : IOverlayNotify
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ioverlaynotify2-ondisplaychange
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnDisplayChange(HMONITOR hMonitor);
}
