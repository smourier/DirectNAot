#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/audiopolicy/nn-audiopolicy-iaudiosessioncontrol
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("f4b1a599-7266-4319-a8ca-e70acb11e8cd")]
public partial interface IAudioSessionControl
{
    // https://learn.microsoft.com/windows/win32/api/audiopolicy/nf-audiopolicy-iaudiosessioncontrol-getstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetState(out AudioSessionState pRetVal);
    
    // https://learn.microsoft.com/windows/win32/api/audiopolicy/nf-audiopolicy-iaudiosessioncontrol-getdisplayname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDisplayName(out PWSTR pRetVal);
    
    // https://learn.microsoft.com/windows/win32/api/audiopolicy/nf-audiopolicy-iaudiosessioncontrol-setdisplayname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDisplayName(PWSTR Value, in Guid EventContext);
    
    // https://learn.microsoft.com/windows/win32/api/audiopolicy/nf-audiopolicy-iaudiosessioncontrol-geticonpath
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetIconPath(out PWSTR pRetVal);
    
    // https://learn.microsoft.com/windows/win32/api/audiopolicy/nf-audiopolicy-iaudiosessioncontrol-seticonpath
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetIconPath(PWSTR Value, in Guid EventContext);
    
    // https://learn.microsoft.com/windows/win32/api/audiopolicy/nf-audiopolicy-iaudiosessioncontrol-getgroupingparam
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetGroupingParam(out Guid pRetVal);
    
    // https://learn.microsoft.com/windows/win32/api/audiopolicy/nf-audiopolicy-iaudiosessioncontrol-setgroupingparam
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetGroupingParam(in Guid Override, in Guid EventContext);
    
    // https://learn.microsoft.com/windows/win32/api/audiopolicy/nf-audiopolicy-iaudiosessioncontrol-registeraudiosessionnotification
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RegisterAudioSessionNotification(IAudioSessionEvents NewNotifications);
    
    // https://learn.microsoft.com/windows/win32/api/audiopolicy/nf-audiopolicy-iaudiosessioncontrol-unregisteraudiosessionnotification
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UnregisterAudioSessionNotification(IAudioSessionEvents NewNotifications);
}
