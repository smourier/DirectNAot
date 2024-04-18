namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_feature_data_serialization
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_FEATURE_DATA_SERIALIZATION
{
    public uint NodeIndex;
    public D3D12_HEAP_SERIALIZATION_TIER HeapSerializationTier;
}
