namespace DirectN;

[GeneratedComInterface, Guid("63bd8738-e30d-4c77-bf5c-834e87c657e2")]
public partial interface IAudioStateMonitor
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RegisterCallback(PAudioStateMonitorCallback callback, nint/* nint */ context, out long registration);
    
    [PreserveSig]
    void UnregisterCallback(long registration);
    
    [PreserveSig]
    AudioStateMonitorSoundLevel GetSoundLevel();
}
