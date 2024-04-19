namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d9/nn-d3d9-idirect3dbasetexture9
[GeneratedComInterface, Guid("580ca87e-1d3c-4d54-991d-b7d3e3c298ce")]
public partial interface IDirect3DBaseTexture9 : IDirect3DResource9
{
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3dbasetexture9-setlod
    [PreserveSig]
    uint SetLOD(uint LODNew);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3dbasetexture9-getlod
    [PreserveSig]
    uint GetLOD();
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3dbasetexture9-getlevelcount
    [PreserveSig]
    uint GetLevelCount();
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3dbasetexture9-setautogenfiltertype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAutoGenFilterType(D3DTEXTUREFILTERTYPE FilterType);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3dbasetexture9-getautogenfiltertype
    [PreserveSig]
    D3DTEXTUREFILTERTYPE GetAutoGenFilterType();
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3dbasetexture9-generatemipsublevels
    [PreserveSig]
    void GenerateMipSubLevels();
}
