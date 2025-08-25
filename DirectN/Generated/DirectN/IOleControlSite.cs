#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ocidl/nn-ocidl-iolecontrolsite
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("b196b289-bab4-101a-b69c-00aa00341d07")]
public partial interface IOleControlSite
{
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-iolecontrolsite-oncontrolinfochanged
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnControlInfoChanged();
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-iolecontrolsite-lockinplaceactive
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT LockInPlaceActive(BOOL fLock);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-iolecontrolsite-getextendedcontrol
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetExtendedControl([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDispatch>))] out IDispatch ppDisp);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-iolecontrolsite-transformcoords
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TransformCoords(ref POINTL pPtlHimetric, ref POINTF pPtfContainer, uint dwFlags);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-iolecontrolsite-translateaccelerator
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TranslateAccelerator(in MSG pMsg, KEYMODIFIERS grfModifiers);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-iolecontrolsite-onfocus
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnFocus(BOOL fGotFocus);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-iolecontrolsite-showpropertyframe
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ShowPropertyFrame();
}
