#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/oleidl/nn-oleidl-idropsource
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("00000121-0000-0000-c000-000000000046")]
public partial interface IDropSource
{
    // https://learn.microsoft.com/windows/win32/api/oleidl/nf-oleidl-idropsource-querycontinuedrag
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT QueryContinueDrag(BOOL fEscapePressed, MODIFIERKEYS_FLAGS grfKeyState);
    
    // https://learn.microsoft.com/windows/win32/api/oleidl/nf-oleidl-idropsource-givefeedback
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GiveFeedback(DROPEFFECT dwEffect);
}
