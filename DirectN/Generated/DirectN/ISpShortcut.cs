#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("3df681e2-ea56-11d9-8bde-f66bad1e3f3a")]
public partial interface ISpShortcut
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddShortcut(PWSTR pszDisplay, ushort LangID, PWSTR pszSpoken, SPSHORTCUTTYPE shType);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveShortcut(PWSTR pszDisplay, ushort LangID, PWSTR pszSpoken, SPSHORTCUTTYPE shType);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetShortcuts(ushort LangID, ref SPSHORTCUTPAIRLIST pShortcutpairList);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetGeneration(out uint pdwGeneration);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetWordsFromGenerationChange(ref uint pdwGeneration, ref SPWORDLIST pWordList);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetWords(ref uint pdwGeneration, ref uint pdwCookie, ref SPWORDLIST pWordList);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetShortcutsForGeneration(ref uint pdwGeneration, ref uint pdwCookie, ref SPSHORTCUTPAIRLIST pShortcutpairList);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetGenerationChange(ref uint pdwGeneration, ref SPSHORTCUTPAIRLIST pShortcutpairList);
}
