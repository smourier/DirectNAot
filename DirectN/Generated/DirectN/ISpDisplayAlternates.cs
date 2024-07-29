#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("c8d7c7e2-0dde-44b7-afe3-b0c991fbeb5e")]
public partial interface ISpDisplayAlternates
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDisplayAlternates(in SPDISPLAYPHRASE pPhrase, uint cRequestCount, ref SPDISPLAYPHRASE ppCoMemPhrases, ref uint pcPhrasesReturned);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFullStopTrailSpace(uint ulTrailSpace);
}
