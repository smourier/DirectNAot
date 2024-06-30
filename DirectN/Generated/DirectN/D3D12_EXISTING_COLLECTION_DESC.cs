#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_existing_collection_desc
public partial struct D3D12_EXISTING_COLLECTION_DESC
{
    public nint pExistingCollection;
    public uint NumExports;
    public nint pExports;
}
