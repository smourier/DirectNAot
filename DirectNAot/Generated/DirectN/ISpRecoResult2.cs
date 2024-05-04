#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("27cac6c4-88f2-41f2-8817-0c95e59f1e6e")]
public partial interface ISpRecoResult2 : ISpRecoResult
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CommitAlternate(ISpPhraseAlt pPhraseAlt, out ISpRecoResult ppNewResult);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CommitText(uint ulStartElement, uint cElements, PWSTR? pszCorrectedData, uint eCommitFlags);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetTextFeedback(PWSTR pszFeedback, [MarshalAs(UnmanagedType.U4)] bool fSuccessful);
}
