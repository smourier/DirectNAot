namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/nn-d3d12-id3d12fence1
[GeneratedComInterface, Guid("433685fe-e22b-4ca0-a8db-b5b4f4dd0e4a")]
public partial interface ID3D12Fence1 : ID3D12Fence
{
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12fence1-getcreationflags
    [PreserveSig]
    D3D12_FENCE_FLAGS GetCreationFlags();
}
