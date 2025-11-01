#nullable enable
namespace DirectN;

public partial struct D3D12_RAYTRACING_OPACITY_MICROMAP_ARRAY_DESC
{
    public uint NumOmmHistogramEntries;
    public nint pOmmHistogram;
    public ulong InputBuffer;
    public D3D12_GPU_VIRTUAL_ADDRESS_AND_STRIDE PerOmmDescs;
}
