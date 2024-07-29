#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-iamtvaudionotification
[GeneratedComInterface, Guid("83ec1c33-23d1-11d1-99e6-00a0c9560266")]
public partial interface IAMTVAudioNotification
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamtvaudionotification-onevent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnEvent(AMTVAudioEventType Event);
}
