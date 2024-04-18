namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d9/nn-d3d9-idirect3dtexture9
[GeneratedComInterface, Guid("85c31227-3de5-4f00-9b3a-f11ac38c18b5")]
public partial interface IDirect3DTexture9 : IDirect3DBaseTexture9
{
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3dtexture9-getleveldesc
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetLevelDesc(uint Level, ref D3DSURFACE_DESC pDesc);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3dtexture9-getsurfacelevel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetSurfaceLevel(uint Level, out IDirect3DSurface9 ppSurfaceLevel);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3dtexture9-lockrect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT LockRect(uint Level, ref D3DLOCKED_RECT pLockedRect, FoundationRECT pRect, uint Flags);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3dtexture9-unlockrect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT UnlockRect(uint Level);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3dtexture9-adddirtyrect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT AddDirtyRect(FoundationRECT pDirtyRect);
}
