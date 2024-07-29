#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("c360ce4b-76d1-4214-ad68-52657d5083da")]
public partial interface ISpEnginePronunciation
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Normalize(PWSTR pszWord, PWSTR pszLeftContext, PWSTR pszRightContext, ushort LangID, ref SPNORMALIZATIONLIST pNormalizationList);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPronunciations(PWSTR pszWord, PWSTR pszLeftContext, PWSTR pszRightContext, ushort LangID, ref SPWORDPRONUNCIATIONLIST pEnginePronunciationList);
}
