#nullable enable
namespace DirectN;

public partial struct D3D12_DRED_AUTO_BREADCRUMBS_OUTPUT1 : IValueGet<nint>
{
    public nint pHeadAutoBreadcrumbNode;
    
    readonly nint IValueGet<nint>.GetValue() => pHeadAutoBreadcrumbNode;
    readonly object? IValueGet.GetValue() => pHeadAutoBreadcrumbNode;
}
