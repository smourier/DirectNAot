namespace DirectN;

[GeneratedComInterface, Guid("b0210783-89cd-11d0-af08-00a0c925cd16")]
public partial interface IDirectSoundNotify
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetNotificationPositions(uint dwPositionNotifies, in DSBPOSITIONNOTIFY pcPositionNotifies);
}
