#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_dxil_subobject_to_exports_association
public partial struct D3D12_DXIL_SUBOBJECT_TO_EXPORTS_ASSOCIATION
{
    public PWSTR SubobjectToAssociate;
    public uint NumExports;
    public nint pExports;
}
