#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfcaptureengine/nn-mfcaptureengine-imfcaptureengineoneventcallback
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("aeda51c0-9025-4983-9012-de597b88b089")]
public partial interface IMFCaptureEngineOnEventCallback
{
    // https://learn.microsoft.com/windows/win32/api/mfcaptureengine/nf-mfcaptureengine-imfcaptureengineoneventcallback-onevent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnEvent(IMFMediaEvent pEvent);
}
