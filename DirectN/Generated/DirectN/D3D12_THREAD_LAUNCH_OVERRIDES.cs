#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_THREAD_LAUNCH_OVERRIDES
{
    public nint pLocalRootArgumentsTableIndex;
    public nint pProgramEntry;
    public nint pNewName;
    public nint pShareInputOf;
    public uint NumOutputOverrides;
    public nint pOutputOverrides;
}
