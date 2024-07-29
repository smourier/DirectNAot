#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/audioclient/nn-audioclient-iaudioeffectschangednotificationclient
[GeneratedComInterface, Guid("a5ded44f-3c5d-4b2b-bd1e-5dc1ee20bbf6")]
public partial interface IAudioEffectsChangedNotificationClient
{
    // https://learn.microsoft.com/windows/win32/api/audioclient/nf-audioclient-iaudioeffectschangednotificationclient-onaudioeffectschanged
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnAudioEffectsChanged();
}
