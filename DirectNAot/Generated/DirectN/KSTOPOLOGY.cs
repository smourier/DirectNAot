#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSTOPOLOGY
{
    public uint CategoriesCount;
    public nint Categories;
    public uint TopologyNodesCount;
    public nint TopologyNodes;
    public uint TopologyConnectionsCount;
    public nint TopologyConnections;
    public nint TopologyNodesNames;
    public uint Reserved;
}
