namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_FEATURE_DATA_D3D12_OPTIONS19
{
    [MarshalAs(UnmanagedType.U4)]
    public bool MismatchingOutputDimensionsSupported;
    public uint SupportedSampleCountsWithNoOutputs;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool PointSamplingAddressesNeverRoundUp;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool RasterizerDesc2Supported;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool NarrowQuadrilateralLinesSupported;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool AnisoFilterWithPointMipSupported;
    public uint MaxSamplerDescriptorHeapSize;
    public uint MaxSamplerDescriptorHeapSizeWithStaticSamplers;
    public uint MaxViewDescriptorHeapSize;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool ComputeOnlyCustomHeapSupported;
}
