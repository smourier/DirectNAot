namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/vmr9/nn-vmr9-ivmrsurfaceallocatorex9
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("6de9a68a-a928-4522-bf57-655ae3866456")]
public partial interface IVMRSurfaceAllocatorEx9 : IVMRSurfaceAllocator9
{
    // https://learn.microsoft.com/windows/win32/api/vmr9/nf-vmr9-ivmrsurfaceallocatorex9-getsurfaceex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSurfaceEx(nuint dwUserID, uint SurfaceIndex, uint SurfaceFlags, out IDirect3DSurface9 lplpSurface, out RECT lprcDst);
}
