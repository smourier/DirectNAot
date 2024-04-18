namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_dred_auto_breadcrumbs_output
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_DRED_AUTO_BREADCRUMBS_OUTPUT
{
    public nint pHeadAutoBreadcrumbNode;
}
