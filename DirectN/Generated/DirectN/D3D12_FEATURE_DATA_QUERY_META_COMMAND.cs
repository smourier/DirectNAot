#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_feature_data_query_meta_command
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_FEATURE_DATA_QUERY_META_COMMAND
{
    public Guid CommandId;
    public uint NodeMask;
    public nint pQueryInputData;
    public nuint QueryInputDataSizeInBytes;
    public nint pQueryOutputData;
    public nuint QueryOutputDataSizeInBytes;
}
