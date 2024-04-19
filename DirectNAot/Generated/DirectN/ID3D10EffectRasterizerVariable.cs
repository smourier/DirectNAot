namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10effect/nn-d3d10effect-id3d10effectrasterizervariable
[GeneratedComInterface, Guid("21af9f0e-4d94-4ea9-9785-2cb76b8c0b34")]
public partial interface ID3D10EffectRasterizerVariable : ID3D10EffectVariable
{
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectrasterizervariable-getrasterizerstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRasterizerState(uint Index, out ID3D10RasterizerState ppRasterizerState);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectrasterizervariable-getbackingstore
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBackingStore(uint Index, out D3D10_RASTERIZER_DESC pRasterizerDesc);
}
