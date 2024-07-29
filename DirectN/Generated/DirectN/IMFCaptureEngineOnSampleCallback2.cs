#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfcaptureengine/nn-mfcaptureengine-imfcaptureengineonsamplecallback2
[SupportedOSPlatform("windows8.1")]
[GeneratedComInterface, Guid("e37ceed7-340f-4514-9f4d-9c2ae026100b")]
public partial interface IMFCaptureEngineOnSampleCallback2 : IMFCaptureEngineOnSampleCallback
{
    // https://learn.microsoft.com/windows/win32/api/mfcaptureengine/nf-mfcaptureengine-imfcaptureengineonsamplecallback2-onsynchronizedevent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnSynchronizedEvent(IMFMediaEvent pEvent);
}
