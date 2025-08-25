#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/oleidl/nn-oleidl-ioleinplaceobject
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("00000113-0000-0000-c000-000000000046")]
public partial interface IOleInPlaceObject : IOleWindow
{
    // https://learn.microsoft.com/windows/win32/api/oleidl/nf-oleidl-ioleinplaceobject-inplacedeactivate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InPlaceDeactivate();
    
    // https://learn.microsoft.com/windows/win32/api/oleidl/nf-oleidl-ioleinplaceobject-uideactivate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UIDeactivate();
    
    // https://learn.microsoft.com/windows/win32/api/oleidl/nf-oleidl-ioleinplaceobject-setobjectrects
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetObjectRects(in RECT lprcPosRect, in RECT lprcClipRect);
    
    // https://learn.microsoft.com/windows/win32/api/oleidl/nf-oleidl-ioleinplaceobject-reactivateandundo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ReactivateAndUndo();
}
