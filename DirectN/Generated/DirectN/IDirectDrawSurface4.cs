#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("0b2b8630-ad35-11d0-8ea6-00609797ea5b")]
public partial interface IDirectDrawSurface4
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddAttachedSurface(IDirectDrawSurface4 param0);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddOverlayDirtyRect(ref RECT param0);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Blt(ref RECT param0, IDirectDrawSurface4 param1, ref RECT param2, uint param3, ref DDBLTFX param4);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT BltBatch(ref DDBLTBATCH param0, uint param1, uint param2);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT BltFast(uint param0, uint param1, IDirectDrawSurface4 param2, ref RECT param3, uint param4);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DeleteAttachedSurface(uint param0, IDirectDrawSurface4 param1);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumAttachedSurfaces(nint param0, LPDDENUMSURFACESCALLBACK2 param1);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumOverlayZOrders(uint param0, nint param1, LPDDENUMSURFACESCALLBACK2 param2);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Flip(IDirectDrawSurface4 param0, uint param1);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAttachedSurface(ref DDSCAPS2 param0, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDirectDrawSurface4>))] out IDirectDrawSurface4 param1);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBltStatus(uint param0);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCaps(ref DDSCAPS2 param0);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetClipper([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDirectDrawClipper>))] out IDirectDrawClipper param0);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetColorKey(uint param0, ref DDCOLORKEY param1);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDC(ref HDC param0);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFlipStatus(uint param0);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetOverlayPosition(ref int param0, ref int param1);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPalette([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDirectDrawPalette>))] out IDirectDrawPalette param0);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPixelFormat(ref DDPIXELFORMAT param0);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSurfaceDesc(ref DDSURFACEDESC2 param0);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Initialize(IDirectDraw param0, ref DDSURFACEDESC2 param1);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsLost();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Lock(ref RECT param0, ref DDSURFACEDESC2 param1, uint param2, HANDLE param3);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ReleaseDC(HDC param0);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Restore();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetClipper(IDirectDrawClipper param0);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetColorKey(uint param0, ref DDCOLORKEY param1);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetOverlayPosition(int param0, int param1);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPalette(IDirectDrawPalette param0);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Unlock(ref RECT param0);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UpdateOverlay(ref RECT param0, IDirectDrawSurface4 param1, ref RECT param2, uint param3, ref DDOVERLAYFX param4);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UpdateOverlayDisplay(uint param0);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UpdateOverlayZOrder(uint param0, IDirectDrawSurface4 param1);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDDInterface(out nint param0);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PageLock(uint param0);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PageUnlock(uint param0);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSurfaceDesc(ref DDSURFACEDESC2 param0, uint param1);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPrivateData(in Guid param0, nint param1, uint param2, uint param3);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPrivateData(in Guid param0, nint param1, ref uint param2);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FreePrivateData(in Guid param0);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetUniquenessValue(ref uint param0);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ChangeUniquenessValue();
}
