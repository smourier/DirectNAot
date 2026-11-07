#nullable enable
namespace DirectN;

public partial struct D3D12_FEATURE_DATA_DUMP_FILE
{
    public BOOL SupportedByOS;
    public D3D12_DUMP_FILE_DRIVER_TIER DumpFileDriverTier;
    public uint DumpFileDriverOptionsMask;
}
