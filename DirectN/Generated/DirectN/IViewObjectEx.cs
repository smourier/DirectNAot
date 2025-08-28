#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ocidl/nn-ocidl-iviewobjectex
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("3af24292-0c96-11ce-a0cf-00aa00600ab8")]
public partial interface IViewObjectEx : IViewObject2
{
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-iviewobjectex-getrect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRect(uint dwAspect, out RECTL pRect);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-iviewobjectex-getviewstatus
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetViewStatus(out uint pdwStatus);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-iviewobjectex-queryhitpoint
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT QueryHitPoint(uint dwAspect, in RECT pRectBounds, POINT ptlLoc, int lCloseHint, out uint pHitResult);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-iviewobjectex-queryhitrect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT QueryHitRect(uint dwAspect, in RECT pRectBounds, in RECT pRectLoc, int lCloseHint, out uint pHitResult);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-iviewobjectex-getnaturalextent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetNaturalExtent(DVASPECT dwAspect, int lindex, nint ptd, HDC hicTargetDev, nint pExtentInfo, nint pSizel);
}
