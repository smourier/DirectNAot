namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d9/nn-d3d9-idirect3dindexbuffer9
[GeneratedComInterface, Guid("7c9dd65e-d3f7-4529-acee-785830acde35")]
public partial interface IDirect3DIndexBuffer9 : IDirect3DResource9
{
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3dindexbuffer9-lock
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Lock(uint OffsetToLock, uint SizeToLock, out nint ppbData, uint Flags);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3dindexbuffer9-unlock
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Unlock();
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3dindexbuffer9-getdesc
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDesc(ref D3DINDEXBUFFER_DESC pDesc);
}
