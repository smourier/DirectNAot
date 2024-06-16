#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/audiopolicy/nn-audiopolicy-iaudiosessionevents
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("24918acc-64b3-37c1-8ca9-74a66e9957a8")]
public partial interface IAudioSessionEvents
{
    // https://learn.microsoft.com/windows/win32/api/audiopolicy/nf-audiopolicy-iaudiosessionevents-ondisplaynamechanged
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnDisplayNameChanged(PWSTR NewDisplayName, in Guid EventContext);
    
    // https://learn.microsoft.com/windows/win32/api/audiopolicy/nf-audiopolicy-iaudiosessionevents-oniconpathchanged
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnIconPathChanged(PWSTR NewIconPath, in Guid EventContext);
    
    // https://learn.microsoft.com/windows/win32/api/audiopolicy/nf-audiopolicy-iaudiosessionevents-onsimplevolumechanged
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnSimpleVolumeChanged(float NewVolume, BOOL NewMute, in Guid EventContext);
    
    // https://learn.microsoft.com/windows/win32/api/audiopolicy/nf-audiopolicy-iaudiosessionevents-onchannelvolumechanged
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnChannelVolumeChanged(uint ChannelCount, [In][MarshalUsing(CountElementName = nameof(ChannelCount))] float[] NewChannelVolumeArray, uint ChangedChannel, in Guid EventContext);
    
    // https://learn.microsoft.com/windows/win32/api/audiopolicy/nf-audiopolicy-iaudiosessionevents-ongroupingparamchanged
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnGroupingParamChanged(in Guid NewGroupingParam, in Guid EventContext);
    
    // https://learn.microsoft.com/windows/win32/api/audiopolicy/nf-audiopolicy-iaudiosessionevents-onstatechanged
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnStateChanged(AudioSessionState NewState);
    
    // https://learn.microsoft.com/windows/win32/api/audiopolicy/nf-audiopolicy-iaudiosessionevents-onsessiondisconnected
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnSessionDisconnected(AudioSessionDisconnectReason DisconnectReason);
}
