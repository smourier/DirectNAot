namespace DirectN;

[GeneratedComInterface, Guid("27864a2a-2b9f-4cb8-92d3-0d2722fd1e73")]
public partial interface ISpeechPhraseAlternate : IDispatch
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_RecoResult(out ISpeechRecoResult RecoResult);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_StartElementInResult(out int StartElement);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_NumberOfElementsInResult(out int NumberOfElements);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_PhraseInfo(out ISpeechPhraseInfo PhraseInfo);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Commit();
}
