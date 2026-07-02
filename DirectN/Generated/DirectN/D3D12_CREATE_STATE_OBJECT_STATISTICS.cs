#nullable enable
namespace DirectN;

public partial struct D3D12_CREATE_STATE_OBJECT_STATISTICS
{
    public uint NumCreated;
    public uint NumPSDBCacheMissed;
    public uint NumTotalCacheMissed;
    public uint NumCacheUnknown;
}
