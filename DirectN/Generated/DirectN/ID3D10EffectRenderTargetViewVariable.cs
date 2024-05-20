#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10effect/nn-d3d10effect-id3d10effectrendertargetviewvariable
[GeneratedComInterface, Guid("28ca0cc3-c2c9-40bb-b57f-67b737122b17")]
public partial interface ID3D10EffectRenderTargetViewVariable : ID3D10EffectVariable
{
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectrendertargetviewvariable-setrendertarget
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetRenderTarget(ID3D10RenderTargetView? pResource);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectrendertargetviewvariable-getrendertarget
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRenderTarget(out ID3D10RenderTargetView ppResource);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectrendertargetviewvariable-setrendertargetarray
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetRenderTargetArray([In][MarshalUsing(CountElementName = nameof(Count))] ID3D10RenderTargetView[] ppResources, uint Offset, uint Count);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10effect/nf-d3d10effect-id3d10effectrendertargetviewvariable-getrendertargetarray
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRenderTargetArray([In][Out][MarshalUsing(CountElementName = nameof(Count))] ID3D10RenderTargetView[] ppResources, uint Offset, uint Count);
}
