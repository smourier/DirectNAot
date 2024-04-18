namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/nn-d3d12-id3d12shadercachesession
[GeneratedComInterface, Guid("28e2495d-0f64-4ae4-a6ec-129255dc49a8")]
public partial interface ID3D12ShaderCacheSession : ID3D12DeviceChild
{
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12shadercachesession-findvalue
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT FindValue(nint pKey, uint KeySize, nint pValue, ref uint pValueSize);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12shadercachesession-storevalue
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT StoreValue(nint pKey, uint KeySize, nint pValue, uint ValueSize);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12shadercachesession-setdeleteondestroy
    [PreserveSig]
    public void SetDeleteOnDestroy();
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12shadercachesession-getdesc
    [PreserveSig]
    public D3D12_SHADER_CACHE_SESSION_DESC GetDesc();
}
