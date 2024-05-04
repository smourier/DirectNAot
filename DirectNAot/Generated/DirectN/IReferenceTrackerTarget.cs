#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/windows.ui.xaml.hosting.referencetracker/nn-windows-ui-xaml-hosting-referencetracker-ireferencetrackertarget
[GeneratedComInterface, Guid("64bd43f8-bfee-4ec4-b7eb-2935158dae21")]
public partial interface IReferenceTrackerTarget
{
    // https://learn.microsoft.com/windows/win32/api/windows.ui.xaml.hosting.referencetracker/nf-windows-ui-xaml-hosting-referencetracker-ireferencetrackertarget-addreffromreferencetracker
    [PreserveSig]
    uint AddRefFromReferenceTracker();
    
    // https://learn.microsoft.com/windows/win32/api/windows.ui.xaml.hosting.referencetracker/nf-windows-ui-xaml-hosting-referencetracker-ireferencetrackertarget-releasefromreferencetracker
    [PreserveSig]
    uint ReleaseFromReferenceTracker();
    
    // https://learn.microsoft.com/windows/win32/api/windows.ui.xaml.hosting.referencetracker/nf-windows-ui-xaml-hosting-referencetracker-ireferencetrackertarget-peg
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Peg();
    
    // https://learn.microsoft.com/windows/win32/api/windows.ui.xaml.hosting.referencetracker/nf-windows-ui-xaml-hosting-referencetracker-ireferencetrackertarget-unpeg
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Unpeg();
}
