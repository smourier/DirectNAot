#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/vmr9/nn-vmr9-ivmrsurfaceallocatornotify9
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("dca3f5df-bb3a-4d03-bd81-84614bfbfa0c")]
public partial interface IVMRSurfaceAllocatorNotify9
{
    // https://learn.microsoft.com/windows/win32/api/vmr9/nf-vmr9-ivmrsurfaceallocatornotify9-advisesurfaceallocator
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AdviseSurfaceAllocator(nuint dwUserID, IVMRSurfaceAllocator9 lpIVRMSurfaceAllocator);
    
    // https://learn.microsoft.com/windows/win32/api/vmr9/nf-vmr9-ivmrsurfaceallocatornotify9-setd3ddevice
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetD3DDevice(IDirect3DDevice9 lpD3DDevice, HMONITOR hMonitor);
    
    // https://learn.microsoft.com/windows/win32/api/vmr9/nf-vmr9-ivmrsurfaceallocatornotify9-changed3ddevice
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ChangeD3DDevice(IDirect3DDevice9 lpD3DDevice, HMONITOR hMonitor);
    
    // https://learn.microsoft.com/windows/win32/api/vmr9/nf-vmr9-ivmrsurfaceallocatornotify9-allocatesurfacehelper
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AllocateSurfaceHelper(in VMR9AllocationInfo lpAllocInfo, ref uint lpNumBuffers, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDirect3DSurface9>))] out IDirect3DSurface9 lplpSurface);
    
    // https://learn.microsoft.com/windows/win32/api/vmr9/nf-vmr9-ivmrsurfaceallocatornotify9-notifyevent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT NotifyEvent(int EventCode, nint Param1, nint Param2);
}
