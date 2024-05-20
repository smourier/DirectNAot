#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfvirtualcamera/nn-mfvirtualcamera-imfcamerasyncobject
[GeneratedComInterface, Guid("6338b23a-3042-49d2-a3ea-ec0fed815407")]
public partial interface IMFCameraSyncObject
{
    // https://learn.microsoft.com/windows/win32/api/mfvirtualcamera/nf-mfvirtualcamera-imfcamerasyncobject-waitonsignal
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT WaitOnSignal(uint timeOutInMs);
    
    // https://learn.microsoft.com/windows/win32/api/mfvirtualcamera/nf-mfvirtualcamera-imfcamerasyncobject-shutdown
    [PreserveSig]
    void Shutdown();
}
