#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfmediaengine/nn-mfmediaengine-imfmediasourceextensionnotify
[SupportedOSPlatform("windows8.1")]
[GeneratedComInterface, Guid("a7901327-05dd-4469-a7b7-0e01979e361d")]
public partial interface IMFMediaSourceExtensionNotify
{
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediasourceextensionnotify-onsourceopen
    [PreserveSig]
    void OnSourceOpen();
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediasourceextensionnotify-onsourceended
    [PreserveSig]
    void OnSourceEnded();
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediasourceextensionnotify-onsourceclose
    [PreserveSig]
    void OnSourceClose();
}
