namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/audiopolicy/nn-audiopolicy-iaudiosessionnotification
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("641dd20b-4d41-49cc-aba3-174b9477bb08")]
public partial interface IAudioSessionNotification
{
    // https://learn.microsoft.com/windows/win32/api/audiopolicy/nf-audiopolicy-iaudiosessionnotification-onsessioncreated
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnSessionCreated(IAudioSessionControl NewSession);
}
