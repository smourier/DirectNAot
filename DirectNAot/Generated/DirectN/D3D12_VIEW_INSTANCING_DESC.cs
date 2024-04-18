namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_view_instancing_desc
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_VIEW_INSTANCING_DESC
{
    public uint ViewInstanceCount;
    public nint pViewInstanceLocations;
    public D3D12_VIEW_INSTANCING_FLAGS Flags;
}
