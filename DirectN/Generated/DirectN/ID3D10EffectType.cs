#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10effect/nn-d3d10effect-id3d10effecttype
public partial struct ID3D10EffectType
{
    public nint VTablePtr;
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effecttype-isvalid
    public unsafe BOOL IsValid()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D10EffectType*, BOOL>)(((void**)VTablePtr)[0]))((ID3D10EffectType*)VTablePtr);
    }
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effecttype-getdesc
    [return: MarshalAs(UnmanagedType.Error)]
    public unsafe HRESULT GetDesc(ref D3D10_EFFECT_TYPE_DESC pDesc)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D10EffectType*,D3D10_EFFECT_TYPE_DESC*, HRESULT>)(((void**)VTablePtr)[1]))((ID3D10EffectType*)VTablePtr, (D3D10_EFFECT_TYPE_DESC*)Unsafe.AsPointer(ref pDesc));
    }
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effecttype-getmembertypebyindex
    public unsafe nint GetMemberTypeByIndex(uint Index)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D10EffectType*,uint, nint>)(((void**)VTablePtr)[2]))((ID3D10EffectType*)VTablePtr, Index);
    }
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effecttype-getmembertypebyname
    public unsafe nint GetMemberTypeByName(PSTR Name)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D10EffectType*,PSTR, nint>)(((void**)VTablePtr)[3]))((ID3D10EffectType*)VTablePtr, Name);
    }
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effecttype-getmembertypebysemantic
    public unsafe nint GetMemberTypeBySemantic(PSTR Semantic)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D10EffectType*,PSTR, nint>)(((void**)VTablePtr)[4]))((ID3D10EffectType*)VTablePtr, Semantic);
    }
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effecttype-getmembername
    public unsafe PSTR GetMemberName(uint Index)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D10EffectType*,uint, PSTR>)(((void**)VTablePtr)[5]))((ID3D10EffectType*)VTablePtr, Index);
    }
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effecttype-getmembersemantic
    public unsafe PSTR GetMemberSemantic(uint Index)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D10EffectType*,uint, PSTR>)(((void**)VTablePtr)[6]))((ID3D10EffectType*)VTablePtr, Index);
    }
}
