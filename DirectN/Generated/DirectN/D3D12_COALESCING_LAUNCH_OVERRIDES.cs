#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_COALESCING_LAUNCH_OVERRIDES
{
    public nint pLocalRootArgumentsTableIndex;
    
    [MarshalAs(UnmanagedType.U4)]
    public nint pProgramEntry;
    public nint pNewName;
    public nint pShareInputOf;
    public uint NumOutputOverrides;
    public nint pOutputOverrides;
}
