#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10/ns-d3d10-d3d10_query_desc
public partial struct D3D10_QUERY_DESC
{
    public D3D10_QUERY Query;
    public uint MiscFlags;
}
