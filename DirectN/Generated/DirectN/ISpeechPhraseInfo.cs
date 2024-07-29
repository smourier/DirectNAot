#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("961559cf-4e67-4662-8bf0-d93f1fcd61b3")]
public partial interface ISpeechPhraseInfo : IDispatch
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_LanguageId(out int LanguageId);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_GrammarId(out VARIANT GrammarId);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_StartTime(out VARIANT StartTime);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_AudioStreamPosition(out VARIANT AudioStreamPosition);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_AudioSizeBytes(out int pAudioSizeBytes);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_RetainedSizeBytes(out int RetainedSizeBytes);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_AudioSizeTime(out int AudioSizeTime);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Rule([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISpeechPhraseRule>))] out ISpeechPhraseRule Rule);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Properties([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISpeechPhraseProperties>))] out ISpeechPhraseProperties Properties);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Elements([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISpeechPhraseElements>))] out ISpeechPhraseElements Elements);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Replacements([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISpeechPhraseReplacements>))] out ISpeechPhraseReplacements Replacements);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_EngineId(out BSTR EngineIdGuid);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_EnginePrivateData(out VARIANT PrivateData);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SaveToMemory(out VARIANT PhraseBlock);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetText(int StartElement, int Elements, VARIANT_BOOL UseReplacements, out BSTR Text);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDisplayAttributes(int StartElement, int Elements, VARIANT_BOOL UseReplacements, out SpeechDisplayAttributes DisplayAttributes);
}
