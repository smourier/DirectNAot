namespace DirectN;

[GeneratedComInterface, Guid("da044e00-69b2-11d0-a1d5-00aa00b8dfbb")]
public partial interface IDirectDrawSurface3
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT AddAttachedSurface(IDirectDrawSurface3 param0);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT AddOverlayDirtyRect(ref FoundationRECT param0);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT Blt(ref FoundationRECT param0, IDirectDrawSurface3 param1, ref FoundationRECT param2, uint param3, ref DDBLTFX param4);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT BltBatch(ref DDBLTBATCH param0, uint param1, uint param2);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT BltFast(uint param0, uint param1, IDirectDrawSurface3 param2, ref FoundationRECT param3, uint param4);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT DeleteAttachedSurface(uint param0, IDirectDrawSurface3 param1);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT EnumAttachedSurfaces(nint param0, LPDDENUMSURFACESCALLBACK param1);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT EnumOverlayZOrders(uint param0, nint param1, LPDDENUMSURFACESCALLBACK param2);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT Flip(IDirectDrawSurface3 param0, uint param1);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetAttachedSurface(ref DDSCAPS param0, out IDirectDrawSurface3 param1);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetBltStatus(uint param0);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetCaps(ref DDSCAPS param0);
    
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
    public HRESULT GetSurfaceDesc(ref DDSURFACEDESC param0);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT Initialize(IDirectDraw param0, ref DDSURFACEDESC param1);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT IsLost();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT Lock(ref FoundationRECT param0, ref DDSURFACEDESC param1, uint param2, HANDLE param3);
    
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
    public HRESULT Unlock(nint param0);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT UpdateOverlay(ref FoundationRECT param0, IDirectDrawSurface3 param1, ref FoundationRECT param2, uint param3, ref DDOVERLAYFX param4);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT UpdateOverlayDisplay(uint param0);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT UpdateOverlayZOrder(uint param0, IDirectDrawSurface3 param1);
    
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
    public HRESULT SetSurfaceDesc(ref DDSURFACEDESC param0, uint param1);
}
