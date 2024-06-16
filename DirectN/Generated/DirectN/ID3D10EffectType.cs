#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10effect/nn-d3d10effect-id3d10effecttype
[GeneratedComInterface, Guid("4e9e1ddc-cd9d-4772-a837-00180b9b88fd")]
public partial interface ID3D10EffectType
{
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effecttype-isvalid
    [PreserveSig]
    BOOL IsValid();
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effecttype-getdesc
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDesc(ref D3D10_EFFECT_TYPE_DESC pDesc);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effecttype-getmembertypebyindex
    [PreserveSig]
    ID3D10EffectType GetMemberTypeByIndex(uint Index);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effecttype-getmembertypebyname
    [PreserveSig]
    ID3D10EffectType GetMemberTypeByName(PSTR Name);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effecttype-getmembertypebysemantic
    [PreserveSig]
    ID3D10EffectType GetMemberTypeBySemantic(PSTR Semantic);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effecttype-getmembername
    [PreserveSig]
    PSTR GetMemberName(uint Index);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effecttype-getmembersemantic
    [PreserveSig]
    PSTR GetMemberSemantic(uint Index);
}
