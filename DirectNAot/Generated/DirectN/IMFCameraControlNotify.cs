namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfcameracontrolnotify
[GeneratedComInterface, Guid("e8f2540d-558a-4449-8b64-4863467a9fe8")]
public partial interface IMFCameraControlNotify
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfcameracontrolnotify-onchange
    [PreserveSig]
    void OnChange(in Guid controlSet, uint id);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfcameracontrolnotify-onerror
    [PreserveSig]
    void OnError(HRESULT hrStatus);
}
