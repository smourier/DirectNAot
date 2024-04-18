namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddraw/nn-ddraw-idirectdraw7
[GeneratedComInterface, Guid("15e65ec0-3b9c-11d2-b92f-00609797ea5b")]
public partial interface IDirectDraw7
{
    // https://learn.microsoft.com/windows/win32/api/ddraw/nf-ddraw-idirectdraw7-compact
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT Compact();
    
    // https://learn.microsoft.com/windows/win32/api/ddraw/nf-ddraw-idirectdraw7-createclipper
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateClipper(uint param0, out IDirectDrawClipper param1, nint param2);
    
    // https://learn.microsoft.com/windows/win32/api/ddraw/nf-ddraw-idirectdraw7-createpalette
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreatePalette(uint param0, ref PALETTEENTRY param1, out IDirectDrawPalette param2, nint param3);
    
    // https://learn.microsoft.com/windows/win32/api/ddraw/nf-ddraw-idirectdraw7-createsurface
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateSurface(ref DDSURFACEDESC2 param0, out IDirectDrawSurface7 param1, nint param2);
    
    // https://learn.microsoft.com/windows/win32/api/ddraw/nf-ddraw-idirectdraw7-duplicatesurface
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT DuplicateSurface(IDirectDrawSurface7 param0, out IDirectDrawSurface7 param1);
    
    // https://learn.microsoft.com/windows/win32/api/ddraw/nf-ddraw-idirectdraw7-enumdisplaymodes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT EnumDisplayModes(uint param0, ref DDSURFACEDESC2 param1, nint param2, LPDDENUMMODESCALLBACK2 param3);
    
    // https://learn.microsoft.com/windows/win32/api/ddraw/nf-ddraw-idirectdraw7-enumsurfaces
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT EnumSurfaces(uint param0, ref DDSURFACEDESC2 param1, nint param2, LPDDENUMSURFACESCALLBACK7 param3);
    
    // https://learn.microsoft.com/windows/win32/api/ddraw/nf-ddraw-idirectdraw7-fliptogdisurface
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT FlipToGDISurface();
    
    // https://learn.microsoft.com/windows/win32/api/ddraw/nf-ddraw-idirectdraw7-getcaps
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetCaps(ref DDCAPS_DX7 param0, ref DDCAPS_DX7 param1);
    
    // https://learn.microsoft.com/windows/win32/api/ddraw/nf-ddraw-idirectdraw7-getdisplaymode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetDisplayMode(ref DDSURFACEDESC2 param0);
    
    // https://learn.microsoft.com/windows/win32/api/ddraw/nf-ddraw-idirectdraw7-getfourcccodes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetFourCCCodes(ref uint param0, ref uint param1);
    
    // https://learn.microsoft.com/windows/win32/api/ddraw/nf-ddraw-idirectdraw7-getgdisurface
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetGDISurface(out IDirectDrawSurface7 param0);
    
    // https://learn.microsoft.com/windows/win32/api/ddraw/nf-ddraw-idirectdraw7-getmonitorfrequency
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetMonitorFrequency(ref uint param0);
    
    // https://learn.microsoft.com/windows/win32/api/ddraw/nf-ddraw-idirectdraw7-getscanline
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetScanLine(ref uint param0);
    
    // https://learn.microsoft.com/windows/win32/api/ddraw/nf-ddraw-idirectdraw7-getverticalblankstatus
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetVerticalBlankStatus([MarshalAs(UnmanagedType.U4)] ref bool param0);
    
    // https://learn.microsoft.com/windows/win32/api/ddraw/nf-ddraw-idirectdraw7-initialize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT Initialize(ref Guid param0);
    
    // https://learn.microsoft.com/windows/win32/api/ddraw/nf-ddraw-idirectdraw7-restoredisplaymode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT RestoreDisplayMode();
    
    // https://learn.microsoft.com/windows/win32/api/ddraw/nf-ddraw-idirectdraw7-setcooperativelevel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetCooperativeLevel(HWND param0, uint param1);
    
    // https://learn.microsoft.com/windows/win32/api/ddraw/nf-ddraw-idirectdraw7-setdisplaymode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetDisplayMode(uint param0, uint param1, uint param2, uint param3, uint param4);
    
    // https://learn.microsoft.com/windows/win32/api/ddraw/nf-ddraw-idirectdraw7-waitforverticalblank
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT WaitForVerticalBlank(uint param0, HANDLE param1);
    
    // https://learn.microsoft.com/windows/win32/api/ddraw/nf-ddraw-idirectdraw7-getavailablevidmem
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetAvailableVidMem(ref DDSCAPS2 param0, ref uint param1, ref uint param2);
    
    // https://learn.microsoft.com/windows/win32/api/ddraw/nf-ddraw-idirectdraw7-getsurfacefromdc
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetSurfaceFromDC(HDC param0, out IDirectDrawSurface7 param1);
    
    // https://learn.microsoft.com/windows/win32/api/ddraw/nf-ddraw-idirectdraw7-restoreallsurfaces
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT RestoreAllSurfaces();
    
    // https://learn.microsoft.com/windows/win32/api/ddraw/nf-ddraw-idirectdraw7-testcooperativelevel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT TestCooperativeLevel();
    
    // https://learn.microsoft.com/windows/win32/api/ddraw/nf-ddraw-idirectdraw7-getdeviceidentifier
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetDeviceIdentifier(ref DDDEVICEIDENTIFIER2 param0, uint param1);
    
    // https://learn.microsoft.com/windows/win32/api/ddraw/nf-ddraw-idirectdraw7-startmodetest
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT StartModeTest(ref FoundationSIZE param0, uint param1, uint param2);
    
    // https://learn.microsoft.com/windows/win32/api/ddraw/nf-ddraw-idirectdraw7-evaluatemode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT EvaluateMode(uint param0, ref uint param1);
}
