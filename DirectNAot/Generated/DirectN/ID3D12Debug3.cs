#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12sdklayers/nn-d3d12sdklayers-id3d12debug3
[GeneratedComInterface, Guid("5cf4e58f-f671-4ff1-a542-3686e3d153d1")]
public partial interface ID3D12Debug3 : ID3D12Debug
{
    // https://learn.microsoft.com/windows/win32/api/d3d12sdklayers/nf-d3d12sdklayers-id3d12debug3-setenablegpubasedvalidation
    [PreserveSig]
    void SetEnableGPUBasedValidation([MarshalAs(UnmanagedType.U4)] bool Enable);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12sdklayers/nf-d3d12sdklayers-id3d12debug3-setenablesynchronizedcommandqueuevalidation
    [PreserveSig]
    void SetEnableSynchronizedCommandQueueValidation([MarshalAs(UnmanagedType.U4)] bool Enable);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12sdklayers/nf-d3d12sdklayers-id3d12debug3-setgpubasedvalidationflags
    [PreserveSig]
    void SetGPUBasedValidationFlags(D3D12_GPU_BASED_VALIDATION_FLAGS Flags);
}
