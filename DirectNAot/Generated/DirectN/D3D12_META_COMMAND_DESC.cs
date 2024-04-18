namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_meta_command_desc
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_META_COMMAND_DESC
{
    public Guid Id;
    public PWSTR Name;
    public D3D12_GRAPHICS_STATES InitializationDirtyState;
    public D3D12_GRAPHICS_STATES ExecutionDirtyState;
}
