namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d9/nn-d3d9-idirect3dcubetexture9
[GeneratedComInterface, Guid("fff32f81-d953-473a-9223-93d652aba93f")]
public partial interface IDirect3DCubeTexture9 : IDirect3DBaseTexture9
{
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3dcubetexture9-getleveldesc
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLevelDesc(uint Level, ref D3DSURFACE_DESC pDesc);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3dcubetexture9-getcubemapsurface
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCubeMapSurface(D3DCUBEMAP_FACES FaceType, uint Level, out IDirect3DSurface9 ppCubeMapSurface);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3dcubetexture9-lockrect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT LockRect(D3DCUBEMAP_FACES FaceType, uint Level, ref D3DLOCKED_RECT pLockedRect, FoundationRECT pRect, uint Flags);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3dcubetexture9-unlockrect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UnlockRect(D3DCUBEMAP_FACES FaceType, uint Level);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3dcubetexture9-adddirtyrect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddDirtyRect(D3DCUBEMAP_FACES FaceType, FoundationRECT pDirtyRect);
}
