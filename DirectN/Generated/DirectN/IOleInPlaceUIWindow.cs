#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/oleidl/nn-oleidl-ioleinplaceuiwindow
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("00000115-0000-0000-c000-000000000046")]
public partial interface IOleInPlaceUIWindow : IOleWindow
{
    // https://learn.microsoft.com/windows/win32/api/oleidl/nf-oleidl-ioleinplaceuiwindow-getborder
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBorder(out RECT lprectBorder);
    
    // https://learn.microsoft.com/windows/win32/api/oleidl/nf-oleidl-ioleinplaceuiwindow-requestborderspace
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RequestBorderSpace(in RECT pborderwidths);
    
    // https://learn.microsoft.com/windows/win32/api/oleidl/nf-oleidl-ioleinplaceuiwindow-setborderspace
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetBorderSpace(in RECT pborderwidths);
    
    // https://learn.microsoft.com/windows/win32/api/oleidl/nf-oleidl-ioleinplaceuiwindow-setactiveobject
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetActiveObject(IOleInPlaceActiveObject pActiveObject, PWSTR pszObjName);
}
