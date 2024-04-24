namespace DirectN;

[GeneratedComInterface, Guid("2f472991-854b-4465-b613-fbafb3ad8ed8")]
public partial interface ISpSREngine
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSite(ISpSREngineSite pSite);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetInputAudioFormat(in Guid pguidSourceFormatId, in WAVEFORMATEX pSourceWaveFormatEx, out Guid pguidDesiredFormatId, out nint ppCoMemDesiredWaveFormatEx);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RecognizeStream(in Guid rguidFmtId, in WAVEFORMATEX pWaveFormatEx, HANDLE hRequestSync, HANDLE hDataAvailable, HANDLE hExit, [MarshalAs(UnmanagedType.U4)] bool fNewAudioStream, [MarshalAs(UnmanagedType.U4)] bool fRealTimeAudio, ISpObjectToken pAudioObjectToken);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetRecoProfile(ISpObjectToken pProfile);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnCreateGrammar(nint pvEngineRecoContext, SPGRAMMARHANDLE hSAPIGrammar, out nint ppvEngineGrammarContext);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnDeleteGrammar(nint pvEngineGrammar);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT LoadProprietaryGrammar(nint pvEngineGrammar, in Guid rguidParam, PWSTR pszStringParam, nint pvDataParam, uint ulDataSize, SPLOADOPTIONS Options);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UnloadProprietaryGrammar(nint pvEngineGrammar);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetProprietaryRuleState(nint pvEngineGrammar, PWSTR pszName, nint pReserved, SPRULESTATE NewState, out uint pcRulesChanged);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetProprietaryRuleIdState(nint pvEngineGrammar, uint dwRuleId, SPRULESTATE NewState);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT LoadSLM(nint pvEngineGrammar, PWSTR pszTopicName);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UnloadSLM(nint pvEngineGrammar);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSLMState(nint pvEngineGrammar, SPRULESTATE NewState);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetWordSequenceData(nint pvEngineGrammar, [MarshalUsing(CountElementName = nameof(cchText))] PWSTR[] pText, uint cchText, in SPTEXTSELECTIONINFO pInfo);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetTextSelection(nint pvEngineGrammar, in SPTEXTSELECTIONINFO pInfo);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsPronounceable(nint pvEngineGrammar, PWSTR pszWord, out SPWORDPRONOUNCEABLE pWordPronounceable);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnCreateRecoContext(SPRECOCONTEXTHANDLE hSAPIRecoContext, out nint ppvEngineContext);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnDeleteRecoContext(nint pvEngineContext);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PrivateCall(nint pvEngineContext, nint pCallFrame, uint ulCallFrameSize);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAdaptationData(nint pvEngineContext, [MarshalUsing(CountElementName = nameof(cch))] PWSTR[] pAdaptationData, uint cch);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPropertyNum(SPPROPSRC eSrc, nint pvSrcObj, PWSTR pName, int lValue);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPropertyNum(SPPROPSRC eSrc, nint pvSrcObj, PWSTR pName, out int lValue);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPropertyString(SPPROPSRC eSrc, nint pvSrcObj, PWSTR pName, PWSTR pValue);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPropertyString(SPPROPSRC eSrc, nint pvSrcObj, PWSTR pName, out PWSTR ppCoMemValue);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetGrammarState(nint pvEngineGrammar, SPGRAMMARSTATE eGrammarState);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT WordNotify(SPCFGNOTIFY Action, uint cWords, in SPWORDENTRY pWords);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RuleNotify(SPCFGNOTIFY Action, uint cRules, in SPRULEENTRY pRules);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PrivateCallEx(nint pvEngineContext, nint pInCallFrame, uint ulInCallFrameSize, out nint ppvCoMemResponse, out uint pulResponseSize);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetContextState(nint pvEngineContext, SPCONTEXTSTATE eContextState);
}
