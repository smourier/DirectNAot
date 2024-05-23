#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("ed2879cf-ced9-4ee6-a534-de0191d5468d")]
public partial interface ISpeechRecoResult : IDispatch
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_RecoContext([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISpeechRecoContext>))] out ISpeechRecoContext RecoContext);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Times([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISpeechRecoResultTimes>))] out ISpeechRecoResultTimes Times);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT putref_AudioFormat(ISpeechAudioFormat? Format);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_AudioFormat([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISpeechAudioFormat>))] out ISpeechAudioFormat Format);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_PhraseInfo([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISpeechPhraseInfo>))] out ISpeechPhraseInfo PhraseInfo);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Alternates(int RequestCount, int StartElement, int Elements, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISpeechPhraseAlternates>))] out ISpeechPhraseAlternates Alternates);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Audio(int StartElement, int Elements, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISpeechMemoryStream>))] out ISpeechMemoryStream Stream);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SpeakAudio(int StartElement, int Elements, SpeechVoiceSpeakFlags Flags, out int StreamNumber);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SaveToMemory(out VARIANT ResultBlock);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DiscardResultInfo(SpeechDiscardType ValueTypes);
}
