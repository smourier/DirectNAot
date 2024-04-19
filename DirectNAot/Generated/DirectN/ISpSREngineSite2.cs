namespace DirectN;

[GeneratedComInterface, Guid("7bc6e012-684a-493e-bdd4-2bf5fbf48cfe")]
public partial interface ISpSREngineSite2 : ISpSREngineSite
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddEventEx(in SPEVENTEX pEvent, SPRECOCONTEXTHANDLE hSAPIRecoContext);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UpdateRecoPosEx(ulong ullCurrentRecoPos, ulong ullCurrentRecoTime);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRuleTransition(uint ulGrammarID, uint RuleIndex, out SPTRANSITIONENTRY pTrans);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RecognitionEx(in SPRECORESULTINFOEX pResultInfo);
}
