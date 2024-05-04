#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("3da7627a-c7ae-4b23-8708-638c50362c25")]
public partial interface ISpeechLexicon : IDispatch
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_GenerationId(out int GenerationId);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetWords(SpeechLexiconType Flags, out int GenerationID, out ISpeechLexiconWords Words);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddPronunciation(BSTR bstrWord, int LangId, SpeechPartOfSpeech PartOfSpeech, BSTR bstrPronunciation);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddPronunciationByPhoneIds(BSTR bstrWord, int LangId, SpeechPartOfSpeech PartOfSpeech, in VARIANT PhoneIds);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemovePronunciation(BSTR bstrWord, int LangId, SpeechPartOfSpeech PartOfSpeech, BSTR bstrPronunciation);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemovePronunciationByPhoneIds(BSTR bstrWord, int LangId, SpeechPartOfSpeech PartOfSpeech, in VARIANT PhoneIds);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPronunciations(BSTR bstrWord, int LangId, SpeechLexiconType TypeFlags, out ISpeechLexiconPronunciations ppPronunciations);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetGenerationChange(ref int GenerationID, out ISpeechLexiconWords ppWords);
}
