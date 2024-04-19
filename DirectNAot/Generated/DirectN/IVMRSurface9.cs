namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/vmr9/nn-vmr9-ivmrsurface9
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("dfc581a1-6e1f-4c3a-8d0a-5e9792ea2afc")]
public partial interface IVMRSurface9
{
    // https://learn.microsoft.com/windows/win32/api/vmr9/nf-vmr9-ivmrsurface9-issurfacelocked
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsSurfaceLocked();
    
    // https://learn.microsoft.com/windows/win32/api/vmr9/nf-vmr9-ivmrsurface9-locksurface
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT LockSurface(out nint /* byte array */ lpSurface);
    
    // https://learn.microsoft.com/windows/win32/api/vmr9/nf-vmr9-ivmrsurface9-unlocksurface
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UnlockSurface();
    
    // https://learn.microsoft.com/windows/win32/api/vmr9/nf-vmr9-ivmrsurface9-getsurface
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSurface(out IDirect3DSurface9 lplpSurface);
}
