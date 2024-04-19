namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfcameraocclusionstatemonitor
[GeneratedComInterface, Guid("cc692f46-c697-47e2-a72d-7b064617749b")]
public partial interface IMFCameraOcclusionStateMonitor
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfcameraocclusionstatemonitor-start
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Start();
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfcameraocclusionstatemonitor-stop
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Stop();
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfcameraocclusionstatemonitor-getsupportedstates
    [PreserveSig]
    uint GetSupportedStates();
}
