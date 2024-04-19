namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d9/nn-d3d9-idirect3dvolume9
[GeneratedComInterface, Guid("24f416e6-1f67-4aa7-b88e-d33f6f3128a1")]
public partial interface IDirect3DVolume9
{
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3dvolume9-getdevice
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDevice(out IDirect3DDevice9 ppDevice);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3dvolume9-setprivatedata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPrivateData(in Guid refguid, nint pData, uint SizeOfData, uint Flags);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3dvolume9-getprivatedata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPrivateData(in Guid refguid, nint pData, ref uint pSizeOfData);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3dvolume9-freeprivatedata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FreePrivateData(in Guid refguid);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3dvolume9-getcontainer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetContainer(in Guid riid, out nint ppContainer);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3dvolume9-getdesc
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDesc(ref D3DVOLUME_DESC pDesc);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3dvolume9-lockbox
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT LockBox(ref D3DLOCKED_BOX pLockedVolume, in D3DBOX pBox, uint Flags);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3dvolume9-unlockbox
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UnlockBox();
}
