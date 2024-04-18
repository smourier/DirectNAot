namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_meta_command_parameter_desc
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_META_COMMAND_PARAMETER_DESC
{
    public PWSTR Name;
    public D3D12_META_COMMAND_PARAMETER_TYPE Type;
    public D3D12_META_COMMAND_PARAMETER_FLAGS Flags;
    public D3D12_RESOURCE_STATES RequiredResourceState;
    public uint StructureOffset;
}
