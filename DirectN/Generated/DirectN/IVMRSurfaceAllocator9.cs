#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/vmr9/nn-vmr9-ivmrsurfaceallocator9
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("8d5148ea-3f5d-46cf-9df1-d1b896eedb1f")]
public partial interface IVMRSurfaceAllocator9
{
    // https://learn.microsoft.com/windows/win32/api/vmr9/nf-vmr9-ivmrsurfaceallocator9-initializedevice
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InitializeDevice(nuint dwUserID, in VMR9AllocationInfo lpAllocInfo, ref uint lpNumBuffers);
    
    // https://learn.microsoft.com/windows/win32/api/vmr9/nf-vmr9-ivmrsurfaceallocator9-terminatedevice
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TerminateDevice(nuint dwID);
    
    // https://learn.microsoft.com/windows/win32/api/vmr9/nf-vmr9-ivmrsurfaceallocator9-getsurface
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSurface(nuint dwUserID, uint SurfaceIndex, uint SurfaceFlags, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDirect3DSurface9>))] out IDirect3DSurface9 lplpSurface);
    
    // https://learn.microsoft.com/windows/win32/api/vmr9/nf-vmr9-ivmrsurfaceallocator9-advisenotify
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AdviseNotify([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IVMRSurfaceAllocatorNotify9>))] IVMRSurfaceAllocatorNotify9 lpIVMRSurfAllocNotify);
}
