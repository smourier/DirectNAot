#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d9/nn-d3d9-idirect3dvertexbuffer9
[GeneratedComInterface, Guid("b64bb1b5-fd70-4df6-bf91-19d0a12455e3")]
public partial interface IDirect3DVertexBuffer9 : IDirect3DResource9
{
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3dvertexbuffer9-lock
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Lock(uint OffsetToLock, uint SizeToLock, out nint ppbData, uint Flags);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3dvertexbuffer9-unlock
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Unlock();
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3dvertexbuffer9-getdesc
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDesc(ref D3DVERTEXBUFFER_DESC pDesc);
}
