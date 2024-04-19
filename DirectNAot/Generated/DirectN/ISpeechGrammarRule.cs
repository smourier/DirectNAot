namespace DirectN;

[GeneratedComInterface, Guid("afe719cf-5dd1-44f2-999c-7a399f1cfccc")]
public partial interface ISpeechGrammarRule : IDispatch
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Attributes(out SpeechRuleAttributes Attributes);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_InitialState(out ISpeechGrammarRuleState State);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Name(out BSTR Name);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Id(out int Id);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Clear();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddResource(BSTR ResourceName, BSTR ResourceValue);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddState(out ISpeechGrammarRuleState State);
}
