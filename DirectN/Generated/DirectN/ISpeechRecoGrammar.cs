#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("b6d6f79f-2158-4e50-b5bc-9a9ccd852a09")]
public partial interface ISpeechRecoGrammar : IDispatch
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Id(out VARIANT Id);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_RecoContext([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISpeechRecoContext>))] out ISpeechRecoContext RecoContext);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_State(SpeechGrammarState State);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_State(out SpeechGrammarState State);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Rules([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISpeechGrammarRules>))] out ISpeechGrammarRules Rules);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Reset(int NewLanguage);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CmdLoadFromFile(BSTR FileName, SpeechLoadOption LoadOption);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CmdLoadFromObject(BSTR ClassId, BSTR GrammarName, SpeechLoadOption LoadOption);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CmdLoadFromResource(int hModule, VARIANT ResourceName, VARIANT ResourceType, int LanguageId, SpeechLoadOption LoadOption);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CmdLoadFromMemory(VARIANT GrammarData, SpeechLoadOption LoadOption);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CmdLoadFromProprietaryGrammar(BSTR ProprietaryGuid, BSTR ProprietaryString, VARIANT ProprietaryData, SpeechLoadOption LoadOption);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CmdSetRuleState(BSTR Name, SpeechRuleState State);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CmdSetRuleIdState(int RuleId, SpeechRuleState State);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DictationLoad(BSTR TopicName, SpeechLoadOption LoadOption);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DictationUnload();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DictationSetState(SpeechRuleState State);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetWordSequenceData(BSTR Text, int TextLength, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISpeechTextSelectionInformation?>))] ISpeechTextSelectionInformation? Info);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetTextSelection([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISpeechTextSelectionInformation?>))] ISpeechTextSelectionInformation? Info);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsPronounceable(BSTR Word, out SpeechWordPronounceable WordPronounceable);
}
