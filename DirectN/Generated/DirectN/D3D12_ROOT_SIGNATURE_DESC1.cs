#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_root_signature_desc1
public partial struct D3D12_ROOT_SIGNATURE_DESC1
{
    public uint NumParameters;
    public nint pParameters;
    public uint NumStaticSamplers;
    public nint pStaticSamplers;
    public D3D12_ROOT_SIGNATURE_FLAGS Flags;
}
