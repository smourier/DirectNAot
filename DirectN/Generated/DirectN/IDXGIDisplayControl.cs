#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxgi1_2/nn-dxgi1_2-idxgidisplaycontrol
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("ea9dbf1a-c88e-4486-854a-98aa0138f30c")]
public partial interface IDXGIDisplayControl
{
    // https://learn.microsoft.com/windows/win32/api/dxgi1_2/nf-dxgi1_2-idxgidisplaycontrol-isstereoenabled
    [PreserveSig]
    BOOL IsStereoEnabled();
    
    // https://learn.microsoft.com/windows/win32/api/dxgi1_2/nf-dxgi1_2-idxgidisplaycontrol-setstereoenabled
    [PreserveSig]
    void SetStereoEnabled(BOOL enabled);
}
