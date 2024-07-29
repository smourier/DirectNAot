#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfqualitymanager
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("8d009d86-5b9f-4115-b1fc-9f80d52ab8ab")]
public partial interface IMFQualityManager
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfqualitymanager-notifytopology
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT NotifyTopology(IMFTopology pTopology);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfqualitymanager-notifypresentationclock
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT NotifyPresentationClock(IMFPresentationClock pClock);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfqualitymanager-notifyprocessinput
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT NotifyProcessInput(IMFTopologyNode pNode, int lInputIndex, IMFSample pSample);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfqualitymanager-notifyprocessoutput
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT NotifyProcessOutput(IMFTopologyNode pNode, int lOutputIndex, IMFSample pSample);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfqualitymanager-notifyqualityevent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT NotifyQualityEvent(nint pObject, IMFMediaEvent pEvent);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfqualitymanager-shutdown
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Shutdown();
}
