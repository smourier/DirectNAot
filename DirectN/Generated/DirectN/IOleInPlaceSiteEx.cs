#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ocidl/nn-ocidl-ioleinplacesiteex
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("9c2cad80-3424-11cf-b670-00aa004cd6d8")]
public partial interface IOleInPlaceSiteEx : IOleInPlaceSite
{
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ioleinplacesiteex-oninplaceactivateex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnInPlaceActivateEx(out BOOL pfNoRedraw, uint dwFlags);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ioleinplacesiteex-oninplacedeactivateex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnInPlaceDeactivateEx(BOOL fNoRedraw);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ioleinplacesiteex-requestuiactivate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RequestUIActivate();
}
