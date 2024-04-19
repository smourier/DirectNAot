namespace DirectN;

[GeneratedComInterface, Guid("95252c5d-9e43-4f4a-9899-48ee73352f9f")]
public partial interface ISpeechLexiconPronunciation : IDispatch
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Type(out SpeechLexiconType LexiconType);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_LangId(out int LangId);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_PartOfSpeech(out SpeechPartOfSpeech PartOfSpeech);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_PhoneIds(out VARIANT PhoneIds);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Symbolic(out BSTR Symbolic);
}
