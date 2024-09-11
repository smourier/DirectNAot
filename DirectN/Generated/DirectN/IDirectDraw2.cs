#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("b3a6f3e0-2b43-11cf-a2de-00aa00b93356")]
public partial interface IDirectDraw2
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
    HRESULT CreateSurface(ref DDSURFACEDESC param0, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDirectDrawSurface>))] out IDirectDrawSurface param1, nint param2);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DuplicateSurface([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDirectDrawSurface>))] IDirectDrawSurface param0, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDirectDrawSurface>))] out IDirectDrawSurface param1);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumDisplayModes(uint param0, ref DDSURFACEDESC param1, nint param2, LPDDENUMMODESCALLBACK param3);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumSurfaces(uint param0, ref DDSURFACEDESC param1, nint param2, LPDDENUMSURFACESCALLBACK param3);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FlipToGDISurface();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCaps(ref DDCAPS_DX7 param0, ref DDCAPS_DX7 param1);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDisplayMode(ref DDSURFACEDESC param0);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFourCCCodes(ref uint param0, ref uint param1);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetGDISurface([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDirectDrawSurface>))] out IDirectDrawSurface param0);
    
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
    HRESULT GetAvailableVidMem(ref DDSCAPS param0, ref uint param1, ref uint param2);
}
