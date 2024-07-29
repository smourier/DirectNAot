#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("cff8e175-019e-11d3-a08e-00c04f8ef9b5")]
public partial interface ISpeechAudio : ISpeechBaseStream
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Status([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISpeechAudioStatus>))] out ISpeechAudioStatus Status);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_BufferInfo([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISpeechAudioBufferInfo>))] out ISpeechAudioBufferInfo BufferInfo);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_DefaultFormat([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISpeechAudioFormat>))] out ISpeechAudioFormat StreamFormat);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Volume(out int Volume);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Volume(int Volume);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_BufferNotifySize(out int BufferNotifySize);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_BufferNotifySize(int BufferNotifySize);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_EventHandle(out int EventHandle);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetState(SpeechAudioState State);
}
