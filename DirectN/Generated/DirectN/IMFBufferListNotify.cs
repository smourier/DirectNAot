#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfmediaengine/nn-mfmediaengine-imfbufferlistnotify
[SupportedOSPlatform("windows8.1")]
[GeneratedComInterface, Guid("24cd47f7-81d8-4785-adb2-af697a963cd2")]
public partial interface IMFBufferListNotify
{
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfbufferlistnotify-onaddsourcebuffer
    [PreserveSig]
    void OnAddSourceBuffer();
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfbufferlistnotify-onremovesourcebuffer
    [PreserveSig]
    void OnRemoveSourceBuffer();
}
