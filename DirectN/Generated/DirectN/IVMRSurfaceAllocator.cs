#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-ivmrsurfaceallocator
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("31ce832e-4484-458b-8cca-f4d7e3db0b52")]
public partial interface IVMRSurfaceAllocator
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ivmrsurfaceallocator-allocatesurface
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AllocateSurface(nuint dwUserID, in VMRALLOCATIONINFO lpAllocInfo, ref uint lpdwActualBuffers, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDirectDrawSurface7>))] out IDirectDrawSurface7 lplpSurface);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ivmrsurfaceallocator-freesurface
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FreeSurface(nuint dwID);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ivmrsurfaceallocator-preparesurface
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PrepareSurface(nuint dwUserID, IDirectDrawSurface7 lpSurface, uint dwSurfaceFlags);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ivmrsurfaceallocator-advisenotify
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AdviseNotify(IVMRSurfaceAllocatorNotify lpIVMRSurfAllocNotify);
}
