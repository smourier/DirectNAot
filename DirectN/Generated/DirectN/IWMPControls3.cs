#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmp/nn-wmp-iwmpcontrols3
[GeneratedComInterface, Guid("a1d1110e-d545-476a-9a78-ac3e4cb1e6bd")]
public partial interface IWMPControls3 : IWMPControls2
{
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpcontrols3-get_audiolanguagecount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_audioLanguageCount(ref int plCount);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpcontrols3-getaudiolanguageid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT getAudioLanguageID(int lIndex, ref int plLangID);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpcontrols3-getaudiolanguagedescription
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT getAudioLanguageDescription(int lIndex, ref BSTR pbstrLangDesc);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpcontrols3-get_currentaudiolanguage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_currentAudioLanguage(ref int plLangID);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpcontrols3-put_currentaudiolanguage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_currentAudioLanguage(int lLangID);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpcontrols3-get_currentaudiolanguageindex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_currentAudioLanguageIndex(ref int plIndex);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpcontrols3-put_currentaudiolanguageindex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_currentAudioLanguageIndex(int lIndex);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpcontrols3-getlanguagename
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT getLanguageName(int lLangID, ref BSTR pbstrLangName);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpcontrols3-get_currentpositiontimecode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_currentPositionTimecode(ref BSTR bstrTimecode);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpcontrols3-put_currentpositiontimecode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_currentPositionTimecode(BSTR bstrTimecode);
}
