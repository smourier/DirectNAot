#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/oleidl/nn-oleidl-ioleinplaceactiveobject
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("00000117-0000-0000-c000-000000000046")]
public partial interface IOleInPlaceActiveObject : IOleWindow
{
    // https://learn.microsoft.com/windows/win32/api/oleidl/nf-oleidl-ioleinplaceactiveobject-translateaccelerator
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TranslateAccelerator(nint /* optional MSG* */ lpmsg);
    
    // https://learn.microsoft.com/windows/win32/api/oleidl/nf-oleidl-ioleinplaceactiveobject-onframewindowactivate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnFrameWindowActivate([MarshalAs(UnmanagedType.U4)] bool fActivate);
    
    // https://learn.microsoft.com/windows/win32/api/oleidl/nf-oleidl-ioleinplaceactiveobject-ondocwindowactivate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnDocWindowActivate([MarshalAs(UnmanagedType.U4)] bool fActivate);
    
    // https://learn.microsoft.com/windows/win32/api/oleidl/nf-oleidl-ioleinplaceactiveobject-resizeborder
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ResizeBorder(in RECT prcBorder, IOleInPlaceUIWindow pUIWindow, [MarshalAs(UnmanagedType.U4)] bool fFrameWindow);
    
    // https://learn.microsoft.com/windows/win32/api/oleidl/nf-oleidl-ioleinplaceactiveobject-enablemodeless
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnableModeless([MarshalAs(UnmanagedType.U4)] bool fEnable);
}
