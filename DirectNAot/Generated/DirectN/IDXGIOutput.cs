namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxgi/nn-dxgi-idxgioutput
[GeneratedComInterface, Guid("ae02eedb-c735-4690-8d52-5a8dc20213aa")]
public partial interface IDXGIOutput : IDXGIObject
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDesc(out DXGI_OUTPUT_DESC pDesc);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDisplayModeList(DXGI_FORMAT EnumFormat, uint Flags, ref uint pNumModes, out DXGI_MODE_DESC pDesc);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FindClosestMatchingMode(in DXGI_MODE_DESC pModeToMatch, out DXGI_MODE_DESC pClosestMatch, nint pConcernedDevice);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT WaitForVBlank();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TakeOwnership(nint pDevice, [MarshalAs(UnmanagedType.U4)]bool Exclusive);
    
    [PreserveSig]
    void ReleaseOwnership();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetGammaControlCapabilities(out DXGI_GAMMA_CONTROL_CAPABILITIES pGammaCaps);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetGammaControl(in DXGI_GAMMA_CONTROL pArray);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetGammaControl(out DXGI_GAMMA_CONTROL pArray);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDisplaySurface(IDXGISurface pScanoutSurface);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDisplaySurfaceData(IDXGISurface pDestination);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFrameStatistics(out DXGI_FRAME_STATISTICS pStats);
}
