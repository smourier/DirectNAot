namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/audioclient/nn-audioclient-iaudioviewmanagerservice
[GeneratedComInterface, Guid("a7a7ef10-1f49-45e0-ad35-612057cc8f74")]
public partial interface IAudioViewManagerService
{
    // https://learn.microsoft.com/windows/win32/api/audioclient/nf-audioclient-iaudioviewmanagerservice-setaudiostreamwindow
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAudioStreamWindow(HWND hwnd);
}
