namespace DirectN;

[GeneratedComInterface, Guid("7ba627d8-33f9-4375-90c5-9985aee5ede5")]
public partial interface ISpSREngine2 : ISpSREngine
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PrivateCallImmediate(nint pvEngineContext, nint pInCallFrame, uint ulInCallFrameSize, out nint ppvCoMemResponse, out uint pulResponseSize);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAdaptationData2(nint pvEngineContext, [In][Out][MarshalUsing(CountElementName = nameof(cch))] PWSTR[] pAdaptationData, uint cch, PWSTR pTopicName, SPADAPTATIONSETTINGS eSettings, SPADAPTATIONRELEVANCE eRelevance);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetGrammarPrefix(nint pvEngineGrammar, PWSTR? pszPrefix, [MarshalAs(UnmanagedType.U4)] bool fIsPrefixRequired);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetRulePriority(SPRULEHANDLE hRule, nint pvClientRuleContext, int nRulePriority);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EmulateRecognition(ISpPhrase pPhrase, uint dwCompareFlags);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSLMWeight(nint pvEngineGrammar, float flWeight);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetRuleWeight(SPRULEHANDLE hRule, nint pvClientRuleContext, float flWeight);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetTrainingState([MarshalAs(UnmanagedType.U4)] bool fDoingTraining, [MarshalAs(UnmanagedType.U4)] bool fAdaptFromTrainingData);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ResetAcousticModelAdaptation();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnLoadCFG(nint pvEngineGrammar, in SPBINARYGRAMMAR pGrammarData, uint ulGrammarID);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnUnloadCFG(nint pvEngineGrammar, uint ulGrammarID);
}
