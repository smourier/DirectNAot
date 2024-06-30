#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_descriptor_range1
public partial struct D3D12_DESCRIPTOR_RANGE1
{
    public D3D12_DESCRIPTOR_RANGE_TYPE RangeType;
    public uint NumDescriptors;
    public uint BaseShaderRegister;
    public uint RegisterSpace;
    public D3D12_DESCRIPTOR_RANGE_FLAGS Flags;
    public uint OffsetInDescriptorsFromTableStart;
}
