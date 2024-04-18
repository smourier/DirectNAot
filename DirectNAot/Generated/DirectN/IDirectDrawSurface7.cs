namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddraw/nn-ddraw-idirectdrawsurface7
[GeneratedComInterface, Guid("06675a80-3b9b-11d2-b92f-00609797ea5b")]
public partial interface IDirectDrawSurface7
{
    // https://learn.microsoft.com/windows/win32/api/ddraw/nf-ddraw-idirectdrawsurface7-addattachedsurface
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT AddAttachedSurface(IDirectDrawSurface7 param0);
    
    // https://learn.microsoft.com/windows/win32/api/ddraw/nf-ddraw-idirectdrawsurface7-addoverlaydirtyrect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT AddOverlayDirtyRect(ref FoundationRECT param0);
    
    // https://learn.microsoft.com/windows/win32/api/ddraw/nf-ddraw-idirectdrawsurface7-blt
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT Blt(ref FoundationRECT param0, IDirectDrawSurface7 param1, ref FoundationRECT param2, uint param3, ref DDBLTFX param4);
    
    // https://learn.microsoft.com/windows/win32/api/ddraw/nf-ddraw-idirectdrawsurface7-bltbatch
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT BltBatch(ref DDBLTBATCH param0, uint param1, uint param2);
    
    // https://learn.microsoft.com/windows/win32/api/ddraw/nf-ddraw-idirectdrawsurface7-bltfast
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT BltFast(uint param0, uint param1, IDirectDrawSurface7 param2, ref FoundationRECT param3, uint param4);
    
    // https://learn.microsoft.com/windows/win32/api/ddraw/nf-ddraw-idirectdrawsurface7-deleteattachedsurface
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT DeleteAttachedSurface(uint param0, IDirectDrawSurface7 param1);
    
    // https://learn.microsoft.com/windows/win32/api/ddraw/nf-ddraw-idirectdrawsurface7-enumattachedsurfaces
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT EnumAttachedSurfaces(nint param0, LPDDENUMSURFACESCALLBACK7 param1);
    
    // https://learn.microsoft.com/windows/win32/api/ddraw/nf-ddraw-idirectdrawsurface7-enumoverlayzorders
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT EnumOverlayZOrders(uint param0, nint param1, LPDDENUMSURFACESCALLBACK7 param2);
    
    // https://learn.microsoft.com/windows/win32/api/ddraw/nf-ddraw-idirectdrawsurface7-flip
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT Flip(IDirectDrawSurface7 param0, uint param1);
    
    // https://learn.microsoft.com/windows/win32/api/ddraw/nf-ddraw-idirectdrawsurface7-getattachedsurface
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetAttachedSurface(ref DDSCAPS2 param0, out IDirectDrawSurface7 param1);
    
    // https://learn.microsoft.com/windows/win32/api/ddraw/nf-ddraw-idirectdrawsurface7-getbltstatus
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetBltStatus(uint param0);
    
    // https://learn.microsoft.com/windows/win32/api/ddraw/nf-ddraw-idirectdrawsurface7-getcaps
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetCaps(ref DDSCAPS2 param0);
    
    // https://learn.microsoft.com/windows/win32/api/ddraw/nf-ddraw-idirectdrawsurface7-getclipper
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetClipper(out IDirectDrawClipper param0);
    
    // https://learn.microsoft.com/windows/win32/api/ddraw/nf-ddraw-idirectdrawsurface7-getcolorkey
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetColorKey(uint param0, ref DDCOLORKEY param1);
    
    // https://learn.microsoft.com/windows/win32/api/ddraw/nf-ddraw-idirectdrawsurface7-getdc
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetDC(ref HDC param0);
    
    // https://learn.microsoft.com/windows/win32/api/ddraw/nf-ddraw-idirectdrawsurface7-getflipstatus
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetFlipStatus(uint param0);
    
    // https://learn.microsoft.com/windows/win32/api/ddraw/nf-ddraw-idirectdrawsurface7-getoverlayposition
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetOverlayPosition(ref int param0, ref int param1);
    
    // https://learn.microsoft.com/windows/win32/api/ddraw/nf-ddraw-idirectdrawsurface7-getpalette
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetPalette(out IDirectDrawPalette param0);
    
    // https://learn.microsoft.com/windows/win32/api/ddraw/nf-ddraw-idirectdrawsurface7-getpixelformat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetPixelFormat(ref DDPIXELFORMAT param0);
    
    // https://learn.microsoft.com/windows/win32/api/ddraw/nf-ddraw-idirectdrawsurface7-getsurfacedesc
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetSurfaceDesc(ref DDSURFACEDESC2 param0);
    
    // https://learn.microsoft.com/windows/win32/api/ddraw/nf-ddraw-idirectdrawsurface7-initialize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT Initialize(IDirectDraw param0, ref DDSURFACEDESC2 param1);
    
    // https://learn.microsoft.com/windows/win32/api/ddraw/nf-ddraw-idirectdrawsurface7-islost
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT IsLost();
    
    // https://learn.microsoft.com/windows/win32/api/ddraw/nf-ddraw-idirectdrawsurface7-lock
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT Lock(ref FoundationRECT param0, ref DDSURFACEDESC2 param1, uint param2, HANDLE param3);
    
    // https://learn.microsoft.com/windows/win32/api/ddraw/nf-ddraw-idirectdrawsurface7-releasedc
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT ReleaseDC(HDC param0);
    
    // https://learn.microsoft.com/windows/win32/api/ddraw/nf-ddraw-idirectdrawsurface7-restore
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT Restore();
    
    // https://learn.microsoft.com/windows/win32/api/ddraw/nf-ddraw-idirectdrawsurface7-setclipper
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetClipper(IDirectDrawClipper param0);
    
    // https://learn.microsoft.com/windows/win32/api/ddraw/nf-ddraw-idirectdrawsurface7-setcolorkey
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetColorKey(uint param0, ref DDCOLORKEY param1);
    
    // https://learn.microsoft.com/windows/win32/api/ddraw/nf-ddraw-idirectdrawsurface7-setoverlayposition
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetOverlayPosition(int param0, int param1);
    
    // https://learn.microsoft.com/windows/win32/api/ddraw/nf-ddraw-idirectdrawsurface7-setpalette
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetPalette(IDirectDrawPalette param0);
    
    // https://learn.microsoft.com/windows/win32/api/ddraw/nf-ddraw-idirectdrawsurface7-unlock
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT Unlock(ref FoundationRECT param0);
    
    // https://learn.microsoft.com/windows/win32/api/ddraw/nf-ddraw-idirectdrawsurface7-updateoverlay
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT UpdateOverlay(ref FoundationRECT param0, IDirectDrawSurface7 param1, ref FoundationRECT param2, uint param3, ref DDOVERLAYFX param4);
    
    // https://learn.microsoft.com/windows/win32/api/ddraw/nf-ddraw-idirectdrawsurface7-updateoverlaydisplay
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT UpdateOverlayDisplay(uint param0);
    
    // https://learn.microsoft.com/windows/win32/api/ddraw/nf-ddraw-idirectdrawsurface7-updateoverlayzorder
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT UpdateOverlayZOrder(uint param0, IDirectDrawSurface7 param1);
    
    // https://learn.microsoft.com/windows/win32/api/ddraw/nf-ddraw-idirectdrawsurface7-getddinterface
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetDDInterface(out nint param0);
    
    // https://learn.microsoft.com/windows/win32/api/ddraw/nf-ddraw-idirectdrawsurface7-pagelock
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT PageLock(uint param0);
    
    // https://learn.microsoft.com/windows/win32/api/ddraw/nf-ddraw-idirectdrawsurface7-pageunlock
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT PageUnlock(uint param0);
    
    // https://learn.microsoft.com/windows/win32/api/ddraw/nf-ddraw-idirectdrawsurface7-setsurfacedesc
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetSurfaceDesc(ref DDSURFACEDESC2 param0, uint param1);
    
    // https://learn.microsoft.com/windows/win32/api/ddraw/nf-ddraw-idirectdrawsurface7-setprivatedata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetPrivateData(in Guid param0, nint param1, uint param2, uint param3);
    
    // https://learn.microsoft.com/windows/win32/api/ddraw/nf-ddraw-idirectdrawsurface7-getprivatedata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetPrivateData(in Guid param0, nint param1, ref uint param2);
    
    // https://learn.microsoft.com/windows/win32/api/ddraw/nf-ddraw-idirectdrawsurface7-freeprivatedata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT FreePrivateData(in Guid param0);
    
    // https://learn.microsoft.com/windows/win32/api/ddraw/nf-ddraw-idirectdrawsurface7-getuniquenessvalue
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetUniquenessValue(ref uint param0);
    
    // https://learn.microsoft.com/windows/win32/api/ddraw/nf-ddraw-idirectdrawsurface7-changeuniquenessvalue
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT ChangeUniquenessValue();
    
    // https://learn.microsoft.com/windows/win32/api/ddraw/nf-ddraw-idirectdrawsurface7-setpriority
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetPriority(uint param0);
    
    // https://learn.microsoft.com/windows/win32/api/ddraw/nf-ddraw-idirectdrawsurface7-getpriority
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetPriority(ref uint param0);
    
    // https://learn.microsoft.com/windows/win32/api/ddraw/nf-ddraw-idirectdrawsurface7-setlod
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetLOD(uint param0);
    
    // https://learn.microsoft.com/windows/win32/api/ddraw/nf-ddraw-idirectdrawsurface7-getlod
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetLOD(ref uint param0);
}
