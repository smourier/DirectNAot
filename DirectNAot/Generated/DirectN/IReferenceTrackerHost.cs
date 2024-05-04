#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/windows.ui.xaml.hosting.referencetracker/nn-windows-ui-xaml-hosting-referencetracker-ireferencetrackerhost
[GeneratedComInterface, Guid("29a71c6a-3c42-4416-a39d-e2825a07a773")]
public partial interface IReferenceTrackerHost
{
    // https://learn.microsoft.com/windows/win32/api/windows.ui.xaml.hosting.referencetracker/nf-windows-ui-xaml-hosting-referencetracker-ireferencetrackerhost-disconnectunusedreferencesources
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DisconnectUnusedReferenceSources(XAML_REFERENCETRACKER_DISCONNECT options);
    
    // https://learn.microsoft.com/windows/win32/api/windows.ui.xaml.hosting.referencetracker/nf-windows-ui-xaml-hosting-referencetracker-ireferencetrackerhost-releasedisconnectedreferencesources
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ReleaseDisconnectedReferenceSources();
    
    // https://learn.microsoft.com/windows/win32/api/windows.ui.xaml.hosting.referencetracker/nf-windows-ui-xaml-hosting-referencetracker-ireferencetrackerhost-notifyendofreferencetrackingonthread
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT NotifyEndOfReferenceTrackingOnThread();
    
    // https://learn.microsoft.com/windows/win32/api/windows.ui.xaml.hosting.referencetracker/nf-windows-ui-xaml-hosting-referencetracker-ireferencetrackerhost-gettrackertarget
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTrackerTarget(nint unknown, out IReferenceTrackerTarget newReference);
    
    // https://learn.microsoft.com/windows/win32/api/windows.ui.xaml.hosting.referencetracker/nf-windows-ui-xaml-hosting-referencetracker-ireferencetrackerhost-addmemorypressure
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddMemoryPressure(ulong bytesAllocated);
    
    // https://learn.microsoft.com/windows/win32/api/windows.ui.xaml.hosting.referencetracker/nf-windows-ui-xaml-hosting-referencetracker-ireferencetrackerhost-removememorypressure
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveMemoryPressure(ulong bytesAllocated);
}
