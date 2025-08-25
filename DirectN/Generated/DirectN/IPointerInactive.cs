#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ocidl/nn-ocidl-ipointerinactive
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("55980ba0-35aa-11cf-b671-00aa004cd6d8")]
public partial interface IPointerInactive
{
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ipointerinactive-getactivationpolicy
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetActivationPolicy(out POINTERINACTIVE pdwPolicy);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ipointerinactive-oninactivemousemove
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnInactiveMouseMove(in RECT pRectBounds, int x, int y, uint grfKeyState);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ipointerinactive-oninactivesetcursor
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnInactiveSetCursor(in RECT pRectBounds, int x, int y, uint dwMouseMsg, BOOL fSetAlways);
}
