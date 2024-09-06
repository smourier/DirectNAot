#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfcameracontrolmonitor
[GeneratedComInterface, Guid("4d46f2c9-28ba-4970-8c7b-1f0c9d80af69")]
public partial interface IMFCameraControlMonitor
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfcameracontrolmonitor-start
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Start();
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfcameracontrolmonitor-stop
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Stop();
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfcameracontrolmonitor-addcontrolsubscription
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddControlSubscription(Guid controlSet, uint id);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfcameracontrolmonitor-removecontrolsubscription
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveControlSubscription(Guid controlSet, uint id);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfcameracontrolmonitor-shutdown
    [PreserveSig]
    void Shutdown();
}
