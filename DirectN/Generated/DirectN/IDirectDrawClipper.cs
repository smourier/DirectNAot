#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddraw/nn-ddraw-idirectdrawclipper
[GeneratedComInterface, Guid("6c14db85-a733-11ce-a521-0020af0be560")]
public partial interface IDirectDrawClipper
{
    // https://learn.microsoft.com/windows/win32/api/ddraw/nf-ddraw-idirectdrawclipper-getcliplist
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetClipList(ref RECT param0, ref RGNDATA param1, ref uint param2);
    
    // https://learn.microsoft.com/windows/win32/api/ddraw/nf-ddraw-idirectdrawclipper-gethwnd
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetHWnd(ref HWND param0);
    
    // https://learn.microsoft.com/windows/win32/api/ddraw/nf-ddraw-idirectdrawclipper-initialize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Initialize([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDirectDraw>))] IDirectDraw param0, uint param1);
    
    // https://learn.microsoft.com/windows/win32/api/ddraw/nf-ddraw-idirectdrawclipper-iscliplistchanged
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsClipListChanged(ref BOOL param0);
    
    // https://learn.microsoft.com/windows/win32/api/ddraw/nf-ddraw-idirectdrawclipper-setcliplist
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetClipList(ref RGNDATA param0, uint param1);
    
    // https://learn.microsoft.com/windows/win32/api/ddraw/nf-ddraw-idirectdrawclipper-sethwnd
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetHWnd(uint param0, HWND param1);
}
