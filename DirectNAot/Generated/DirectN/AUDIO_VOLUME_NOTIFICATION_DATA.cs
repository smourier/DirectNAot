﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/endpointvolume/ns-endpointvolume-audio_volume_notification_data
[StructLayout(LayoutKind.Sequential)]
public partial struct AUDIO_VOLUME_NOTIFICATION_DATA
{
    public Guid guidEventContext;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool bMuted;
    public float fMasterVolume;
    public uint nChannels;
    public InlineArraySingle1 afChannelVolumes; // variable-length array placeholder
}
