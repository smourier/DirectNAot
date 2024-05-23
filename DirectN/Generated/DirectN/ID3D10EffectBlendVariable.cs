#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10effect/nn-d3d10effect-id3d10effectblendvariable
[GeneratedComInterface, Guid("1fcd2294-df6d-4eae-86b3-0e9160cfb07b")]
public partial interface ID3D10EffectBlendVariable : ID3D10EffectVariable
{
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectblendvariable-getblendstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBlendState(uint Index, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D10BlendState>))] out ID3D10BlendState ppBlendState);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectblendvariable-getbackingstore
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBackingStore(uint Index, ref D3D10_BLEND_DESC pBlendDesc);
}
