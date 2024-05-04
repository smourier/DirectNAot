#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d9/nn-d3d9-idirect3dvolumetexture9
[GeneratedComInterface, Guid("2518526c-e789-4111-a7b9-47ef328d13e6")]
public partial interface IDirect3DVolumeTexture9 : IDirect3DBaseTexture9
{
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3dvolumetexture9-getleveldesc
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLevelDesc(uint Level, ref D3DVOLUME_DESC pDesc);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3dvolumetexture9-getvolumelevel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVolumeLevel(uint Level, out IDirect3DVolume9 ppVolumeLevel);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3dvolumetexture9-lockbox
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT LockBox(uint Level, ref D3DLOCKED_BOX pLockedVolume, in D3DBOX pBox, uint Flags);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3dvolumetexture9-unlockbox
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UnlockBox(uint Level);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3dvolumetexture9-adddirtybox
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddDirtyBox(in D3DBOX pDirtyBox);
}
