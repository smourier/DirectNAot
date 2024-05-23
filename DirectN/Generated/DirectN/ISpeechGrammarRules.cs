#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("6ffa3b44-fc2d-40d1-8afc-32911c7f1ad1")]
public partial interface ISpeechGrammarRules : IDispatch
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Count(out int Count);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FindRule(VARIANT RuleNameOrId, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISpeechGrammarRule>))] out ISpeechGrammarRule Rule);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Item(int Index, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISpeechGrammarRule>))] out ISpeechGrammarRule Rule);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get__NewEnum([MarshalUsing(typeof(UniqueComInterfaceMarshaller<nint>))] out nint EnumVARIANT);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Dynamic(out VARIANT_BOOL Dynamic);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Add(BSTR RuleName, SpeechRuleAttributes Attributes, int RuleId, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISpeechGrammarRule>))] out ISpeechGrammarRule Rule);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Commit();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CommitAndSave(out BSTR ErrorText, out VARIANT SaveStream);
}
