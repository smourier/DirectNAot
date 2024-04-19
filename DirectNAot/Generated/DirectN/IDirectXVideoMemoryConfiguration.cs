namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxva2api/nn-dxva2api-idirectxvideomemoryconfiguration
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("b7f916dd-db3b-49c1-84d7-e45ef99ec726")]
public partial interface IDirectXVideoMemoryConfiguration
{
    // https://learn.microsoft.com/windows/win32/api/dxva2api/nf-dxva2api-idirectxvideomemoryconfiguration-getavailablesurfacetypebyindex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAvailableSurfaceTypeByIndex(uint dwTypeIndex, out DXVA2_SurfaceType pdwType);
    
    // https://learn.microsoft.com/windows/win32/api/dxva2api/nf-dxva2api-idirectxvideomemoryconfiguration-setsurfacetype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSurfaceType(DXVA2_SurfaceType dwType);
}
