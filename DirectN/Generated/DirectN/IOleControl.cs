#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ocidl/nn-ocidl-iolecontrol
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("b196b288-bab4-101a-b69c-00aa00341d07")]
public partial interface IOleControl
{
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-iolecontrol-getcontrolinfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetControlInfo(ref CONTROLINFO pCI);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-iolecontrol-onmnemonic
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnMnemonic(in MSG pMsg);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-iolecontrol-onambientpropertychange
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnAmbientPropertyChange(int dispID);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-iolecontrol-freezeevents
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FreezeEvents(BOOL bFreeze);
}
