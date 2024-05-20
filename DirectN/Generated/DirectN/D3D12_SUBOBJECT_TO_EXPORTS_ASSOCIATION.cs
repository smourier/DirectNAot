#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_subobject_to_exports_association
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_SUBOBJECT_TO_EXPORTS_ASSOCIATION
{
    public nint pSubobjectToAssociate;
    public uint NumExports;
    public nint pExports;
}
