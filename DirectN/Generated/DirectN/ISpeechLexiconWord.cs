#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("4e5b933c-c9be-48ed-8842-1ee51bb1d4ff")]
public partial interface ISpeechLexiconWord : IDispatch
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_LangId(out int LangId);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Type(out SpeechWordType WordType);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Word(out BSTR Word);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Pronunciations([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISpeechLexiconPronunciations>))] out ISpeechLexiconPronunciations Pronunciations);
}
