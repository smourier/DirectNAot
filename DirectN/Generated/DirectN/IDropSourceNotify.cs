#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/oleidl/nn-oleidl-idropsourcenotify
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("0000012b-0000-0000-c000-000000000046")]
public partial interface IDropSourceNotify
{
    // https://learn.microsoft.com/windows/win32/api/oleidl/nf-oleidl-idropsourcenotify-dragentertarget
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DragEnterTarget(HWND hwndTarget);
    
    // https://learn.microsoft.com/windows/win32/api/oleidl/nf-oleidl-idropsourcenotify-dragleavetarget
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DragLeaveTarget();
}
