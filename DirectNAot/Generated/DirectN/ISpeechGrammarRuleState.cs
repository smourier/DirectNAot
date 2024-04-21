namespace DirectN;

[GeneratedComInterface, Guid("d4286f2c-ee67-45ae-b928-28d695362eda")]
public partial interface ISpeechGrammarRuleState : IDispatch
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Rule(out ISpeechGrammarRule Rule);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Transitions(out ISpeechGrammarRuleStateTransitions Transitions);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddWordTransition(ISpeechGrammarRuleState? DestState, BSTR Words, BSTR Separators, SpeechGrammarWordType Type, BSTR PropertyName, int PropertyId, in VARIANT PropertyValue, float Weight);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddRuleTransition(ISpeechGrammarRuleState? DestinationState, ISpeechGrammarRule? Rule, BSTR PropertyName, int PropertyId, in VARIANT PropertyValue, float Weight);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddSpecialTransition(ISpeechGrammarRuleState? DestinationState, SpeechSpecialTransitionType Type, BSTR PropertyName, int PropertyId, in VARIANT PropertyValue, float Weight);
}
