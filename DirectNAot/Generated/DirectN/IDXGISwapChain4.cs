namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxgi1_5/nn-dxgi1_5-idxgiswapchain4
[GeneratedComInterface, Guid("3d585d5a-bd4a-489e-b1f4-3dbcb6452ffb")]
public partial interface IDXGISwapChain4 : IDXGISwapChain3
{
    // https://learn.microsoft.com/windows/win32/api/dxgi1_5/nf-dxgi1_5-idxgiswapchain4-sethdrmetadata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetHDRMetaData(DXGI_HDR_METADATA_TYPE Type, uint Size, nint /* optional void* */ pMetaData);
}
