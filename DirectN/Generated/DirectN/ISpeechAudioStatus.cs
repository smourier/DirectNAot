#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("c62d9c91-7458-47f6-862d-1ef86fb0b278")]
public partial interface ISpeechAudioStatus : IDispatch
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_FreeBufferSpace(out int FreeBufferSpace);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_NonBlockingIO(out int NonBlockingIO);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_State(out SpeechAudioState State);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_CurrentSeekPosition(out VARIANT CurrentSeekPosition);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_CurrentDevicePosition(out VARIANT CurrentDevicePosition);
}
