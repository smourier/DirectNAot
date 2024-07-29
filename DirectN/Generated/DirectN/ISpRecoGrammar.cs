#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("2177db29-7f45-47d0-8554-067e91c80502")]
public partial interface ISpRecoGrammar : ISpGrammarBuilder
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetGrammarId(ref ulong pullGrammarId);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRecoContext([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISpRecoContext>))] out ISpRecoContext ppRecoCtxt);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT LoadCmdFromFile(PWSTR pszFileName, SPLOADOPTIONS Options);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT LoadCmdFromObject(in Guid rcid, PWSTR pszGrammarName, SPLOADOPTIONS Options);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT LoadCmdFromResource(HMODULE hModule, PWSTR pszResourceName, PWSTR pszResourceType, ushort wLanguage, SPLOADOPTIONS Options);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT LoadCmdFromMemory(in SPBINARYGRAMMAR pGrammar, SPLOADOPTIONS Options);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT LoadCmdFromProprietaryGrammar(in Guid rguidParam, PWSTR pszStringParam, nint pvDataPrarm, uint cbDataSize, SPLOADOPTIONS Options);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetRuleState(PWSTR pszName, nint pReserved, SPRULESTATE NewState);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetRuleIdState(uint ulRuleId, SPRULESTATE NewState);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT LoadDictation(PWSTR pszTopicName, SPLOADOPTIONS Options);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UnloadDictation();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDictationState(SPRULESTATE NewState);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetWordSequenceData([MarshalUsing(CountElementName = nameof(cchText))] PWSTR pText, uint cchText, in SPTEXTSELECTIONINFO pInfo);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetTextSelection(in SPTEXTSELECTIONINFO pInfo);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsPronounceable(PWSTR pszWord, ref SPWORDPRONOUNCEABLE pWordPronounceable);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetGrammarState(SPGRAMMARSTATE eGrammarState);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SaveCmd(IStream pStream, nint /* optional PWSTR* */ ppszCoMemErrorText);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetGrammarState(ref SPGRAMMARSTATE peGrammarState);
}
