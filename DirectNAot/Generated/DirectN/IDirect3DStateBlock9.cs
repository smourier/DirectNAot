namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d9/nn-d3d9-idirect3dstateblock9
[GeneratedComInterface, Guid("b07c4fe5-310d-4ba8-a23c-4f0f206f218b")]
public partial interface IDirect3DStateBlock9
{
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3dstateblock9-getdevice
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetDevice(out IDirect3DDevice9 ppDevice);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3dstateblock9-capture
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT Capture();
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3dstateblock9-apply
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT Apply();
}
