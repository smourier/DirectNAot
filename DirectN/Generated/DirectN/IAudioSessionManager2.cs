#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/audiopolicy/nn-audiopolicy-iaudiosessionmanager2
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("77aa99a0-1bd6-484f-8bc7-2c654c9a9b6f")]
public partial interface IAudioSessionManager2 : IAudioSessionManager
{
    // https://learn.microsoft.com/windows/win32/api/audiopolicy/nf-audiopolicy-iaudiosessionmanager2-getsessionenumerator
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSessionEnumerator([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IAudioSessionEnumerator>))] out IAudioSessionEnumerator SessionEnum);
    
    // https://learn.microsoft.com/windows/win32/api/audiopolicy/nf-audiopolicy-iaudiosessionmanager2-registersessionnotification
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RegisterSessionNotification([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IAudioSessionNotification>))] IAudioSessionNotification SessionNotification);
    
    // https://learn.microsoft.com/windows/win32/api/audiopolicy/nf-audiopolicy-iaudiosessionmanager2-unregistersessionnotification
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UnregisterSessionNotification([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IAudioSessionNotification>))] IAudioSessionNotification SessionNotification);
    
    // https://learn.microsoft.com/windows/win32/api/audiopolicy/nf-audiopolicy-iaudiosessionmanager2-registerducknotification
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RegisterDuckNotification(PWSTR sessionID, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IAudioVolumeDuckNotification>))] IAudioVolumeDuckNotification duckNotification);
    
    // https://learn.microsoft.com/windows/win32/api/audiopolicy/nf-audiopolicy-iaudiosessionmanager2-unregisterducknotification
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UnregisterDuckNotification([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IAudioVolumeDuckNotification>))] IAudioVolumeDuckNotification duckNotification);
}
