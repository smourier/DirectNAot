#nullable enable
namespace DirectN;

public partial struct D3D12_DEPTH_STENCIL_FORMAT : IValueGet<DXGI_FORMAT>
{
    public DXGI_FORMAT DepthStencilFormat;
    
    readonly DXGI_FORMAT IValueGet<DXGI_FORMAT>.GetValue() => DepthStencilFormat;
    readonly object? IValueGet.GetValue() => DepthStencilFormat;
}
