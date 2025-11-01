#nullable enable
namespace DirectN;

public partial struct DXCoreProcessMemoryQueryInput
{
    public uint physicalAdapterIndex;
    public DXCoreMemoryType memoryType;
    public uint processId;
}
