#nullable enable
namespace DirectN;

public partial struct D3D12_FEATURE_DATA_D3D12_OPTIONS19
{
    public BOOL MismatchingOutputDimensionsSupported;
    public uint SupportedSampleCountsWithNoOutputs;
    public BOOL PointSamplingAddressesNeverRoundUp;
    public BOOL RasterizerDesc2Supported;
    public BOOL NarrowQuadrilateralLinesSupported;
    public BOOL AnisoFilterWithPointMipSupported;
    public uint MaxSamplerDescriptorHeapSize;
    public uint MaxSamplerDescriptorHeapSizeWithStaticSamplers;
    public uint MaxViewDescriptorHeapSize;
    public BOOL ComputeOnlyCustomHeapSupported;
}
