#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/oleidl/nn-oleidl-ioleinplacesite
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("00000119-0000-0000-c000-000000000046")]
public partial interface IOleInPlaceSite : IOleWindow
{
    // https://learn.microsoft.com/windows/win32/api/oleidl/nf-oleidl-ioleinplacesite-caninplaceactivate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CanInPlaceActivate();
    
    // https://learn.microsoft.com/windows/win32/api/oleidl/nf-oleidl-ioleinplacesite-oninplaceactivate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnInPlaceActivate();
    
    // https://learn.microsoft.com/windows/win32/api/oleidl/nf-oleidl-ioleinplacesite-onuiactivate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnUIActivate();
    
    // https://learn.microsoft.com/windows/win32/api/oleidl/nf-oleidl-ioleinplacesite-getwindowcontext
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetWindowContext([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IOleInPlaceFrame>))] out IOleInPlaceFrame ppFrame, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IOleInPlaceUIWindow>))] out IOleInPlaceUIWindow ppDoc, out RECT lprcPosRect, out RECT lprcClipRect, ref OLEINPLACEFRAMEINFO lpFrameInfo);
    
    // https://learn.microsoft.com/windows/win32/api/oleidl/nf-oleidl-ioleinplacesite-scroll
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Scroll(SIZE scrollExtant);
    
    // https://learn.microsoft.com/windows/win32/api/oleidl/nf-oleidl-ioleinplacesite-onuideactivate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnUIDeactivate(BOOL fUndoable);
    
    // https://learn.microsoft.com/windows/win32/api/oleidl/nf-oleidl-ioleinplacesite-oninplacedeactivate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnInPlaceDeactivate();
    
    // https://learn.microsoft.com/windows/win32/api/oleidl/nf-oleidl-ioleinplacesite-discardundostate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DiscardUndoState();
    
    // https://learn.microsoft.com/windows/win32/api/oleidl/nf-oleidl-ioleinplacesite-deactivateandundo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DeactivateAndUndo();
    
    // https://learn.microsoft.com/windows/win32/api/oleidl/nf-oleidl-ioleinplacesite-onposrectchange
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnPosRectChange(in RECT lprcPosRect);
}
