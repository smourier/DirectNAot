#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("9c59509a-39bd-11d1-8c4a-00c04fd930c5")]
public partial interface IDirectDraw4
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Compact();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateClipper(uint param0, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDirectDrawClipper>))] out IDirectDrawClipper param1, nint param2);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreatePalette(uint param0, ref PALETTEENTRY param1, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDirectDrawPalette>))] out IDirectDrawPalette param2, nint param3);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateSurface(ref DDSURFACEDESC2 param0, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDirectDrawSurface4>))] out IDirectDrawSurface4 param1, nint param2);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DuplicateSurface([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDirectDrawSurface4>))] IDirectDrawSurface4 param0, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDirectDrawSurface4>))] out IDirectDrawSurface4 param1);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumDisplayModes(uint param0, ref DDSURFACEDESC2 param1, nint param2, LPDDENUMMODESCALLBACK2 param3);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumSurfaces(uint param0, ref DDSURFACEDESC2 param1, nint param2, LPDDENUMSURFACESCALLBACK2 param3);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FlipToGDISurface();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCaps(ref DDCAPS_DX7 param0, ref DDCAPS_DX7 param1);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDisplayMode(ref DDSURFACEDESC2 param0);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFourCCCodes(ref uint param0, ref uint param1);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetGDISurface([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDirectDrawSurface4>))] out IDirectDrawSurface4 param0);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMonitorFrequency(ref uint param0);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetScanLine(ref uint param0);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVerticalBlankStatus(ref BOOL param0);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Initialize(ref Guid param0);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RestoreDisplayMode();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetCooperativeLevel(HWND param0, uint param1);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDisplayMode(uint param0, uint param1, uint param2, uint param3, uint param4);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT WaitForVerticalBlank(uint param0, HANDLE param1);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAvailableVidMem(ref DDSCAPS2 param0, ref uint param1, ref uint param2);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSurfaceFromDC(HDC param0, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDirectDrawSurface4>))] out IDirectDrawSurface4 param1);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RestoreAllSurfaces();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TestCooperativeLevel();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDeviceIdentifier(ref DDDEVICEIDENTIFIER param0, uint param1);
}
