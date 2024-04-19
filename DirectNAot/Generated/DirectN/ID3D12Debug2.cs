namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12sdklayers/nn-d3d12sdklayers-id3d12debug2
[GeneratedComInterface, Guid("93a665c4-a3b2-4e5d-b692-a26ae14e3374")]
public partial interface ID3D12Debug2
{
    // https://learn.microsoft.com/windows/win32/api/d3d12sdklayers/nf-d3d12sdklayers-id3d12debug2-setgpubasedvalidationflags
    [PreserveSig]
    void SetGPUBasedValidationFlags(D3D12_GPU_BASED_VALIDATION_FLAGS Flags);
}
