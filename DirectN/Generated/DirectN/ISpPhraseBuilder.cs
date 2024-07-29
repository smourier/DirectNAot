#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("88a3342a-0bed-4834-922b-88d43173162f")]
public partial interface ISpPhraseBuilder : ISpPhrase
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InitFromPhrase(in SPPHRASE pPhrase);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InitFromSerializedPhrase(in SPSERIALIZEDPHRASE pPhrase);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddElements(uint cElements, in SPPHRASEELEMENT pElement);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddRules(SPPHRASERULEHANDLE hParent, in SPPHRASERULE pRule, out SPPHRASERULEHANDLE phNewRule);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddProperties(SPPHRASEPROPERTYHANDLE hParent, in SPPHRASEPROPERTY pProperty, out SPPHRASEPROPERTYHANDLE phNewProperty);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddReplacements(uint cReplacements, in SPPHRASEREPLACEMENT pReplacements);
}
