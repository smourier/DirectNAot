namespace DirectN;

[GeneratedComInterface, Guid("3b414aec-720c-4883-b9ef-178cd394fb3a")]
public partial interface ISpSREngineSite
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Read(nint pv, uint cb, out uint pcbRead);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DataAvailable(out uint pcb);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetBufferNotifySize(uint cbSize);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ParseFromTransitions(in SPPARSEINFO pParseInfo, out ISpPhraseBuilder ppNewPhrase);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Recognition(in SPRECORESULTINFO pResultInfo);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddEvent(in SPEVENT pEvent, SPRECOCONTEXTHANDLE hSAPIRecoContext);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Synchronize(ulong ullProcessedThruPos);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetWordInfo(ref SPWORDENTRY pWordEntry, SPWORDINFOOPT Options);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetWordClientContext(SPWORDHANDLE hWord, nint pvClientContext);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRuleInfo(ref SPRULEENTRY pRuleEntry, SPRULEINFOOPT Options);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetRuleClientContext(SPRULEHANDLE hRule, nint pvClientContext);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStateInfo(SPSTATEHANDLE hState, out SPSTATEINFO pStateInfo);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetResource(SPRULEHANDLE hRule, PWSTR pszResourceName, out PWSTR ppCoMemResource);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTransitionProperty(SPTRANSITIONID ID, out nint ppCoMemProperty);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsAlternate(SPRULEHANDLE hRule, SPRULEHANDLE hAltRule);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMaxAlternates(SPRULEHANDLE hRule, out uint pulNumAlts);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetContextMaxAlternates(SPRECOCONTEXTHANDLE hContext, out uint pulNumAlts);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UpdateRecoPos(ulong ullCurrentRecoPos);
}
