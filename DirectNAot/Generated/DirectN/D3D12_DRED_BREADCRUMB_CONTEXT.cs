#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_DRED_BREADCRUMB_CONTEXT
{
    public uint BreadcrumbIndex;
    public PWSTR pContextString;
}
