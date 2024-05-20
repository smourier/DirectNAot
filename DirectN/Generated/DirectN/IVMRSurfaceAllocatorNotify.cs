#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-ivmrsurfaceallocatornotify
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("aada05a8-5a4e-4729-af0b-cea27aed51e2")]
public partial interface IVMRSurfaceAllocatorNotify
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ivmrsurfaceallocatornotify-advisesurfaceallocator
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AdviseSurfaceAllocator(nuint dwUserID, IVMRSurfaceAllocator lpIVRMSurfaceAllocator);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ivmrsurfaceallocatornotify-setddrawdevice
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDDrawDevice(IDirectDraw7 lpDDrawDevice, HMONITOR hMonitor);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ivmrsurfaceallocatornotify-changeddrawdevice
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ChangeDDrawDevice(IDirectDraw7 lpDDrawDevice, HMONITOR hMonitor);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ivmrsurfaceallocatornotify-restoreddrawsurfaces
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RestoreDDrawSurfaces();
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ivmrsurfaceallocatornotify-notifyevent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT NotifyEvent(int EventCode, nint Param1, nint Param2);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ivmrsurfaceallocatornotify-setbordercolor
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetBorderColor(COLORREF clrBorder);
}
