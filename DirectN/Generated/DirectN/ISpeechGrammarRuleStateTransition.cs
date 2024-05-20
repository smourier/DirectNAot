#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("cafd1db1-41d1-4a06-9863-e2e81da17a9a")]
public partial interface ISpeechGrammarRuleStateTransition : IDispatch
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Type(out SpeechGrammarRuleStateTransitionType Type);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Text(out BSTR Text);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Rule(out ISpeechGrammarRule Rule);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Weight(out VARIANT Weight);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_PropertyName(out BSTR PropertyName);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_PropertyId(out int PropertyId);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_PropertyValue(out VARIANT PropertyValue);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_NextState(out ISpeechGrammarRuleState NextState);
}
