#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/oleidl/nn-oleidl-ioleinplaceframe
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("00000116-0000-0000-c000-000000000046")]
public partial interface IOleInPlaceFrame : IOleInPlaceUIWindow
{
    // https://learn.microsoft.com/windows/win32/api/oleidl/nf-oleidl-ioleinplaceframe-insertmenus
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InsertMenus(HMENU hmenuShared, ref OLEMENUGROUPWIDTHS lpMenuWidths);
    
    // https://learn.microsoft.com/windows/win32/api/oleidl/nf-oleidl-ioleinplaceframe-setmenu
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetMenu(HMENU hmenuShared, nint holemenu, HWND hwndActiveObject);
    
    // https://learn.microsoft.com/windows/win32/api/oleidl/nf-oleidl-ioleinplaceframe-removemenus
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveMenus(HMENU hmenuShared);
    
    // https://learn.microsoft.com/windows/win32/api/oleidl/nf-oleidl-ioleinplaceframe-setstatustext
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetStatusText(PWSTR pszStatusText);
    
    // https://learn.microsoft.com/windows/win32/api/oleidl/nf-oleidl-ioleinplaceframe-enablemodeless
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnableModeless(BOOL fEnable);
    
    // https://learn.microsoft.com/windows/win32/api/oleidl/nf-oleidl-ioleinplaceframe-translateaccelerator
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TranslateAccelerator(in MSG lpmsg, ushort wID);
}
