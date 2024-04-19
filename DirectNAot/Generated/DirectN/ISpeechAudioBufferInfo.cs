namespace DirectN;

[GeneratedComInterface, Guid("11b103d8-1142-4edf-a093-82fb3915f8cc")]
public partial interface ISpeechAudioBufferInfo : IDispatch
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_MinNotification(out int MinNotification);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_MinNotification(int MinNotification);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_BufferSize(out int BufferSize);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_BufferSize(int BufferSize);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_EventBias(out int EventBias);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_EventBias(int EventBias);
}
