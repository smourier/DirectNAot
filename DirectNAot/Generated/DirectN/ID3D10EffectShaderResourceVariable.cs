#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10effect/nn-d3d10effect-id3d10effectshaderresourcevariable
[GeneratedComInterface, Guid("c0a7157b-d872-4b1d-8073-efc2acd4b1fc")]
public partial interface ID3D10EffectShaderResourceVariable : ID3D10EffectVariable
{
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectshaderresourcevariable-setresource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetResource(ID3D10ShaderResourceView? pResource);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectshaderresourcevariable-getresource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetResource(out ID3D10ShaderResourceView ppResource);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectshaderresourcevariable-setresourcearray
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetResourceArray([In][MarshalUsing(CountElementName = nameof(Count))] ID3D10ShaderResourceView[] ppResources, uint Offset, uint Count);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectshaderresourcevariable-getresourcearray
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetResourceArray([In][Out][MarshalUsing(CountElementName = nameof(Count))] ID3D10ShaderResourceView[] ppResources, uint Offset, uint Count);
}
