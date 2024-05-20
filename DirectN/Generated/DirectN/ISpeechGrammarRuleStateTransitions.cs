#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("eabce657-75bc-44a2-aa7f-c56476742963")]
public partial interface ISpeechGrammarRuleStateTransitions : IDispatch
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Count(out int Count);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Item(int Index, out ISpeechGrammarRuleStateTransition Transition);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get__NewEnum(out nint EnumVARIANT);
}
