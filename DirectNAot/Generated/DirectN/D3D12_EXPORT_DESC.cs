namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_export_desc
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_EXPORT_DESC
{
    public PWSTR Name;
    public PWSTR ExportToRename;
    public D3D12_EXPORT_FLAGS Flags;
}
