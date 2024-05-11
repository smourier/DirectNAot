#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_WORK_GRAPH_DESC
{
    public PWSTR ProgramName;
    public D3D12_WORK_GRAPH_FLAGS Flags;
    public uint NumEntrypoints;
    public nint pEntrypoints;
    public uint NumExplicitlyDefinedNodes;
    public nint pExplicitlyDefinedNodes;
}
