#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/control/nn-control-imediaeventex
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("56a868c0-0ad4-11ce-b03a-0020af0ba770")]
public partial interface IMediaEventEx : IMediaEvent
{
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-imediaeventex-setnotifywindow
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetNotifyWindow(nint hwnd, int lMsg, nint lInstanceData);
    
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-imediaeventex-setnotifyflags
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetNotifyFlags(int lNoNotifyFlags);
    
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-imediaeventex-getnotifyflags
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetNotifyFlags(out int lplNoNotifyFlags);
}
