#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_RASTERIZER_DESC1
{
    public D3D12_FILL_MODE FillMode;
    public D3D12_CULL_MODE CullMode;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool FrontCounterClockwise;
    public float DepthBias;
    public float DepthBiasClamp;
    public float SlopeScaledDepthBias;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool DepthClipEnable;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool MultisampleEnable;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool AntialiasedLineEnable;
    public uint ForcedSampleCount;
    public D3D12_CONSERVATIVE_RASTERIZATION_MODE ConservativeRaster;
}
