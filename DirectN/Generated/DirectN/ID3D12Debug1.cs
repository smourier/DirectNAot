#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12sdklayers/nn-d3d12sdklayers-id3d12debug1
[GeneratedComInterface, Guid("affaa4ca-63fe-4d8e-b8ad-159000af4304")]
public partial interface ID3D12Debug1
{
    // https://learn.microsoft.com/windows/win32/api/d3d12sdklayers/nf-d3d12sdklayers-id3d12debug1-enabledebuglayer
    [PreserveSig]
    void EnableDebugLayer();
    
    // https://learn.microsoft.com/windows/win32/api/d3d12sdklayers/nf-d3d12sdklayers-id3d12debug1-setenablegpubasedvalidation
    [PreserveSig]
    void SetEnableGPUBasedValidation(BOOL Enable);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12sdklayers/nf-d3d12sdklayers-id3d12debug1-setenablesynchronizedcommandqueuevalidation
    [PreserveSig]
    void SetEnableSynchronizedCommandQueueValidation(BOOL Enable);
}
