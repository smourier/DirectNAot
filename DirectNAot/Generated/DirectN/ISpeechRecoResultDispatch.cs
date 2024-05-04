#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("6d60eb64-aced-40a6-bbf3-4e557f71dee2")]
public partial interface ISpeechRecoResultDispatch : IDispatch
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_RecoContext(out ISpeechRecoContext RecoContext);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Times(out ISpeechRecoResultTimes Times);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT putref_AudioFormat(ISpeechAudioFormat? Format);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_AudioFormat(out ISpeechAudioFormat Format);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_PhraseInfo(out ISpeechPhraseInfo PhraseInfo);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Alternates(int RequestCount, int StartElement, int Elements, out ISpeechPhraseAlternates Alternates);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Audio(int StartElement, int Elements, out ISpeechMemoryStream Stream);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SpeakAudio(int StartElement, int Elements, SpeechVoiceSpeakFlags Flags, out int StreamNumber);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SaveToMemory(out VARIANT ResultBlock);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DiscardResultInfo(SpeechDiscardType ValueTypes);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetXMLResult(SPXMLRESULTOPTIONS Options, out BSTR pResult);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetXMLErrorInfo(out int LineNumber, out BSTR ScriptLine, out BSTR Source, out BSTR Description, out HRESULT ResultCode, out VARIANT_BOOL IsError);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetTextFeedback(BSTR Feedback, VARIANT_BOOL WasSuccessful);
}
