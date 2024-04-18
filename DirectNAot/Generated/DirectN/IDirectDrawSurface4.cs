namespace DirectN;

[GeneratedComInterface, Guid("0b2b8630-ad35-11d0-8ea6-00609797ea5b")]
public partial interface IDirectDrawSurface4
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT AddAttachedSurface(IDirectDrawSurface4 param0);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT AddOverlayDirtyRect(ref FoundationRECT param0);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT Blt(ref FoundationRECT param0, IDirectDrawSurface4 param1, ref FoundationRECT param2, uint param3, ref DDBLTFX param4);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT BltBatch(ref DDBLTBATCH param0, uint param1, uint param2);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT BltFast(uint param0, uint param1, IDirectDrawSurface4 param2, ref FoundationRECT param3, uint param4);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT DeleteAttachedSurface(uint param0, IDirectDrawSurface4 param1);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT EnumAttachedSurfaces(nint param0, LPDDENUMSURFACESCALLBACK2 param1);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT EnumOverlayZOrders(uint param0, nint param1, LPDDENUMSURFACESCALLBACK2 param2);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT Flip(IDirectDrawSurface4 param0, uint param1);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetAttachedSurface(ref DDSCAPS2 param0, out IDirectDrawSurface4 param1);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetBltStatus(uint param0);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetCaps(ref DDSCAPS2 param0);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetClipper(out IDirectDrawClipper param0);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetColorKey(uint param0, ref DDCOLORKEY param1);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetDC(ref HDC param0);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetFlipStatus(uint param0);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetOverlayPosition(ref int param0, ref int param1);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetPalette(out IDirectDrawPalette param0);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetPixelFormat(ref DDPIXELFORMAT param0);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetSurfaceDesc(ref DDSURFACEDESC2 param0);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT Initialize(IDirectDraw param0, ref DDSURFACEDESC2 param1);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT IsLost();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT Lock(ref FoundationRECT param0, ref DDSURFACEDESC2 param1, uint param2, HANDLE param3);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT ReleaseDC(HDC param0);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT Restore();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetClipper(IDirectDrawClipper param0);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetColorKey(uint param0, ref DDCOLORKEY param1);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetOverlayPosition(int param0, int param1);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetPalette(IDirectDrawPalette param0);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT Unlock(ref FoundationRECT param0);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT UpdateOverlay(ref FoundationRECT param0, IDirectDrawSurface4 param1, ref FoundationRECT param2, uint param3, ref DDOVERLAYFX param4);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT UpdateOverlayDisplay(uint param0);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT UpdateOverlayZOrder(uint param0, IDirectDrawSurface4 param1);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetDDInterface(out nint param0);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT PageLock(uint param0);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT PageUnlock(uint param0);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetSurfaceDesc(ref DDSURFACEDESC2 param0, uint param1);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetPrivateData(in Guid param0, nint param1, uint param2, uint param3);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetPrivateData(in Guid param0, nint param1, ref uint param2);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT FreePrivateData(in Guid param0);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetUniquenessValue(ref uint param0);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT ChangeUniquenessValue();
}
