#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("bead311c-52ff-437f-9464-6b21054ca73d")]
public partial interface ISpRecoContext2
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetGrammarOptions(uint eGrammarOptions);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetGrammarOptions(ref uint peGrammarOptions);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAdaptationData2(PWSTR pAdaptationData, uint cch, PWSTR pTopicName, uint eAdaptationSettings, SPADAPTATIONRELEVANCE eRelevance);
}
