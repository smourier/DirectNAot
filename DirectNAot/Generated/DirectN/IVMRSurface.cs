namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-ivmrsurface
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("a9849bbe-9ec8-4263-b764-62730f0d15d0")]
public partial interface IVMRSurface
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ivmrsurface-issurfacelocked
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsSurfaceLocked();
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ivmrsurface-locksurface
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT LockSurface(out nint /* byte array */ lpSurface);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ivmrsurface-unlocksurface
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UnlockSurface();
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ivmrsurface-getsurface
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSurface(out IDirectDrawSurface7 lplpSurface);
}
