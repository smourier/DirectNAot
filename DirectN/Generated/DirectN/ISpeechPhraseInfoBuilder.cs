#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("3b151836-df3a-4e0a-846c-d2adc9334333")]
public partial interface ISpeechPhraseInfoBuilder : IDispatch
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RestorePhraseFromMemory(in VARIANT PhraseInMemory, out ISpeechPhraseInfo PhraseInfo);
}
