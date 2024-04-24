namespace DirectN;

[GeneratedComInterface, Guid("da41a7c2-5383-4db2-916b-6c1719e3db58")]
public partial interface ISpLexicon
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPronunciations(PWSTR pszWord, ushort LangID, uint dwFlags, ref SPWORDPRONUNCIATIONLIST pWordPronunciationList);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddPronunciation(PWSTR pszWord, ushort LangID, SPPARTOFSPEECH ePartOfSpeech, nint /* optional ushort* */ pszPronunciation);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemovePronunciation(PWSTR pszWord, ushort LangID, SPPARTOFSPEECH ePartOfSpeech, nint /* optional ushort* */ pszPronunciation);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetGeneration(ref uint pdwGeneration);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetGenerationChange(uint dwFlags, ref uint pdwGeneration, ref SPWORDLIST pWordList);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetWords(uint dwFlags, ref uint pdwGeneration, nint /* optional uint* */ pdwCookie, ref SPWORDLIST pWordList);
}
