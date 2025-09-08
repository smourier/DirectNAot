#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ocidl/nn-ocidl-isimpleframesite
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("742b0e01-14e6-101b-914e-00aa00300cab")]
public partial interface ISimpleFrameSite
{
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-isimpleframesite-premessagefilter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PreMessageFilter(HWND hWnd, uint msg, WPARAM wp, LPARAM lp, out LRESULT plResult, out uint pdwCookie);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-isimpleframesite-postmessagefilter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PostMessageFilter(HWND hWnd, uint msg, WPARAM wp, LPARAM lp, out LRESULT plResult, uint dwCookie);
}
