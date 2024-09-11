#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("e6e9c590-3e18-40e3-8299-061f98bde7c7")]
public partial interface ISpeechAudioFormat : IDispatch
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Type(out SpeechAudioFormatType AudioFormat);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Type(SpeechAudioFormatType AudioFormat);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Guid(out BSTR Guid);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Guid(BSTR Guid);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetWaveFormatEx([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISpeechWaveFormatEx>))] out ISpeechWaveFormatEx SpeechWaveFormatEx);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetWaveFormatEx([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISpeechWaveFormatEx?>))] ISpeechWaveFormatEx? SpeechWaveFormatEx);
}
