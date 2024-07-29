#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/windows.ui.xaml.hosting.referencetracker/nn-windows-ui-xaml-hosting-referencetracker-ireferencetracker
[GeneratedComInterface, Guid("11d3b13a-180e-4789-a8be-7712882893e6")]
public partial interface IReferenceTracker
{
    // https://learn.microsoft.com/windows/win32/api/windows.ui.xaml.hosting.referencetracker/nf-windows-ui-xaml-hosting-referencetracker-ireferencetracker-connectfromtrackersource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ConnectFromTrackerSource();
    
    // https://learn.microsoft.com/windows/win32/api/windows.ui.xaml.hosting.referencetracker/nf-windows-ui-xaml-hosting-referencetracker-ireferencetracker-disconnectfromtrackersource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DisconnectFromTrackerSource();
    
    // https://learn.microsoft.com/windows/win32/api/windows.ui.xaml.hosting.referencetracker/nf-windows-ui-xaml-hosting-referencetracker-ireferencetracker-findtrackertargets
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FindTrackerTargets(IFindReferenceTargetsCallback callback);
    
    // https://learn.microsoft.com/windows/win32/api/windows.ui.xaml.hosting.referencetracker/nf-windows-ui-xaml-hosting-referencetracker-ireferencetracker-getreferencetrackermanager
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetReferenceTrackerManager([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IReferenceTrackerManager>))] out IReferenceTrackerManager value);
    
    // https://learn.microsoft.com/windows/win32/api/windows.ui.xaml.hosting.referencetracker/nf-windows-ui-xaml-hosting-referencetracker-ireferencetracker-addreffromtrackersource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddRefFromTrackerSource();
    
    // https://learn.microsoft.com/windows/win32/api/windows.ui.xaml.hosting.referencetracker/nf-windows-ui-xaml-hosting-referencetracker-ireferencetracker-releasefromtrackersource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ReleaseFromTrackerSource();
    
    // https://learn.microsoft.com/windows/win32/api/windows.ui.xaml.hosting.referencetracker/nf-windows-ui-xaml-hosting-referencetracker-ireferencetracker-pegfromtrackersource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PegFromTrackerSource();
}
