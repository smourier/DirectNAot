namespace DirectN;

[GeneratedComInterface, Guid("e6176f96-e373-4801-b223-3b62c068c0b4")]
public partial interface ISpeechPhraseElement : IDispatch
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_AudioTimeOffset(out int AudioTimeOffset);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_AudioSizeTime(out int AudioSizeTime);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_AudioStreamOffset(out int AudioStreamOffset);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_AudioSizeBytes(out int AudioSizeBytes);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_RetainedStreamOffset(out int RetainedStreamOffset);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_RetainedSizeBytes(out int RetainedSizeBytes);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_DisplayText(out BSTR DisplayText);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_LexicalForm(out BSTR LexicalForm);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Pronunciation(out VARIANT Pronunciation);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_DisplayAttributes(out SpeechDisplayAttributes DisplayAttributes);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_RequiredConfidence(out SpeechEngineConfidence RequiredConfidence);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ActualConfidence(out SpeechEngineConfidence ActualConfidence);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_EngineConfidence(out float EngineConfidence);
}
