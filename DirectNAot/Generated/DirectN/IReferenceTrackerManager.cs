namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/windows.ui.xaml.hosting.referencetracker/nn-windows-ui-xaml-hosting-referencetracker-ireferencetrackermanager
[GeneratedComInterface, Guid("3cf184b4-7ccb-4dda-8455-7e6ce99a3298")]
public partial interface IReferenceTrackerManager
{
    // https://learn.microsoft.com/windows/win32/api/windows.ui.xaml.hosting.referencetracker/nf-windows-ui-xaml-hosting-referencetracker-ireferencetrackermanager-referencetrackingstarted
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ReferenceTrackingStarted();
    
    // https://learn.microsoft.com/windows/win32/api/windows.ui.xaml.hosting.referencetracker/nf-windows-ui-xaml-hosting-referencetracker-ireferencetrackermanager-findtrackertargetscompleted
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FindTrackerTargetsCompleted(byte findFailed);
    
    // https://learn.microsoft.com/windows/win32/api/windows.ui.xaml.hosting.referencetracker/nf-windows-ui-xaml-hosting-referencetracker-ireferencetrackermanager-referencetrackingcompleted
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ReferenceTrackingCompleted();
    
    // https://learn.microsoft.com/windows/win32/api/windows.ui.xaml.hosting.referencetracker/nf-windows-ui-xaml-hosting-referencetracker-ireferencetrackermanager-setreferencetrackerhost
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetReferenceTrackerHost(IReferenceTrackerHost value);
}
