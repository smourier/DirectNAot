namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxgi/nn-dxgi-idxgioutput
[GeneratedComInterface, Guid("ae02eedb-c735-4690-8d52-5a8dc20213aa")]
public partial interface IDXGIOutput : IDXGIObject
{
    // https://learn.microsoft.com/windows/win32/api/dxgi/nf-dxgi-idxgioutput-getdesc
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDesc(out DXGI_OUTPUT_DESC pDesc);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi/nf-dxgi-idxgioutput-getdisplaymodelist
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDisplayModeList(DXGI_FORMAT EnumFormat, uint Flags, ref uint pNumModes, nint/* nint */ pDesc);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi/nf-dxgi-idxgioutput-findclosestmatchingmode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FindClosestMatchingMode(in DXGI_MODE_DESC pModeToMatch, out DXGI_MODE_DESC pClosestMatch, nint pConcernedDevice);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi/nf-dxgi-idxgioutput-waitforvblank
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT WaitForVBlank();
    
    // https://learn.microsoft.com/windows/win32/api/dxgi/nf-dxgi-idxgioutput-takeownership
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TakeOwnership(nint pDevice, [MarshalAs(UnmanagedType.U4)] bool Exclusive);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi/nf-dxgi-idxgioutput-releaseownership
    [PreserveSig]
    void ReleaseOwnership();
    
    // https://learn.microsoft.com/windows/win32/api/dxgi/nf-dxgi-idxgioutput-getgammacontrolcapabilities
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetGammaControlCapabilities(out DXGI_GAMMA_CONTROL_CAPABILITIES pGammaCaps);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi/nf-dxgi-idxgioutput-setgammacontrol
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetGammaControl(in DXGI_GAMMA_CONTROL pArray);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi/nf-dxgi-idxgioutput-getgammacontrol
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetGammaControl(out DXGI_GAMMA_CONTROL pArray);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi/nf-dxgi-idxgioutput-setdisplaysurface
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDisplaySurface(IDXGISurface pScanoutSurface);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi/nf-dxgi-idxgioutput-getdisplaysurfacedata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDisplaySurfaceData(IDXGISurface pDestination);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi/nf-dxgi-idxgioutput-getframestatistics
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFrameStatistics(out DXGI_FRAME_STATISTICS pStats);
}
