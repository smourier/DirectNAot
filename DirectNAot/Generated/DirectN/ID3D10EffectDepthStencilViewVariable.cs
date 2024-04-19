namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10effect/nn-d3d10effect-id3d10effectdepthstencilviewvariable
[GeneratedComInterface, Guid("3e02c918-cc79-4985-b622-2d92ad701623")]
public partial interface ID3D10EffectDepthStencilViewVariable : ID3D10EffectVariable
{
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectdepthstencilviewvariable-setdepthstencil
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDepthStencil(ID3D10DepthStencilView pResource);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectdepthstencilviewvariable-getdepthstencil
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDepthStencil(out ID3D10DepthStencilView ppResource);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectdepthstencilviewvariable-setdepthstencilarray
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDepthStencilArray(in ID3D10DepthStencilView ppResources, uint Offset, uint Count);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectdepthstencilviewvariable-getdepthstencilarray
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDepthStencilArray(out ID3D10DepthStencilView ppResources, uint Offset, uint Count);
}
