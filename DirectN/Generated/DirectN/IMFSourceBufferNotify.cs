#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfmediaengine/nn-mfmediaengine-imfsourcebuffernotify
[SupportedOSPlatform("windows8.1")]
[GeneratedComInterface, Guid("87e47623-2ceb-45d6-9b88-d8520c4dcbbc")]
public partial interface IMFSourceBufferNotify
{
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfsourcebuffernotify-onupdatestart
    [PreserveSig]
    void OnUpdateStart();
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfsourcebuffernotify-onabort
    [PreserveSig]
    void OnAbort();
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfsourcebuffernotify-onerror
    [PreserveSig]
    void OnError(HRESULT hr);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfsourcebuffernotify-onupdate
    [PreserveSig]
    void OnUpdate();
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfsourcebuffernotify-onupdateend
    [PreserveSig]
    void OnUpdateEnd();
}
