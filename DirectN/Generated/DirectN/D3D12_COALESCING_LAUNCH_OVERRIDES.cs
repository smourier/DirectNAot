#nullable enable
namespace DirectN;

public partial struct D3D12_COALESCING_LAUNCH_OVERRIDES
{
    public nint pLocalRootArgumentsTableIndex;
    public nint pProgramEntry;
    public nint pNewName;
    public nint pShareInputOf;
    public uint NumOutputOverrides;
    public nint pOutputOverrides;
}
