namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfplay/nn-mfplay-imfpmediaplayercallback
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("766c8ffb-5fdb-4fea-a28d-b912996f51bd")]
public partial interface IMFPMediaPlayerCallback
{
    // https://learn.microsoft.com/windows/win32/api/mfplay/nf-mfplay-imfpmediaplayercallback-onmediaplayerevent
    [PreserveSig]
    void OnMediaPlayerEvent(in MFP_EVENT_HEADER pEventHeader);
}
