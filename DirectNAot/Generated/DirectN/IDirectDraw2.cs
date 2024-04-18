namespace DirectN;

[GeneratedComInterface, Guid("b3a6f3e0-2b43-11cf-a2de-00aa00b93356")]
public partial interface IDirectDraw2
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT Compact();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateClipper(uint param0, out IDirectDrawClipper param1, nint param2);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreatePalette(uint param0, ref PALETTEENTRY param1, out IDirectDrawPalette param2, nint param3);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateSurface(ref DDSURFACEDESC param0, out IDirectDrawSurface param1, nint param2);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT DuplicateSurface(IDirectDrawSurface param0, out IDirectDrawSurface param1);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT EnumDisplayModes(uint param0, ref DDSURFACEDESC param1, nint param2, LPDDENUMMODESCALLBACK param3);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT EnumSurfaces(uint param0, ref DDSURFACEDESC param1, nint param2, LPDDENUMSURFACESCALLBACK param3);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT FlipToGDISurface();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetCaps(ref DDCAPS_DX7 param0, ref DDCAPS_DX7 param1);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetDisplayMode(ref DDSURFACEDESC param0);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetFourCCCodes(ref uint param0, ref uint param1);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetGDISurface(out IDirectDrawSurface param0);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetMonitorFrequency(ref uint param0);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetScanLine(ref uint param0);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetVerticalBlankStatus([MarshalAs(UnmanagedType.U4)] ref bool param0);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT Initialize(ref Guid param0);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT RestoreDisplayMode();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetCooperativeLevel(HWND param0, uint param1);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetDisplayMode(uint param0, uint param1, uint param2, uint param3, uint param4);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT WaitForVerticalBlank(uint param0, HANDLE param1);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetAvailableVidMem(ref DDSCAPS param0, ref uint param1, ref uint param2);
}
