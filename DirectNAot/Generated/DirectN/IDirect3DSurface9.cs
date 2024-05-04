#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d9/nn-d3d9-idirect3dsurface9
[GeneratedComInterface, Guid("0cfbaf3a-9ff6-429a-99b3-a2796af8b89b")]
public partial interface IDirect3DSurface9 : IDirect3DResource9
{
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3dsurface9-getcontainer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetContainer(in Guid riid, out nint ppContainer);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3dsurface9-getdesc
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDesc(ref D3DSURFACE_DESC pDesc);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3dsurface9-lockrect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT LockRect(ref D3DLOCKED_RECT pLockedRect, in RECT pRect, uint Flags);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3dsurface9-unlockrect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UnlockRect();
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3dsurface9-getdc
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDC(ref HDC phdc);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3dsurface9-releasedc
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ReleaseDC(HDC hdc);
}
