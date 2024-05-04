#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_input_element_desc
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_INPUT_ELEMENT_DESC
{
    public PSTR SemanticName;
    public uint SemanticIndex;
    public DXGI_FORMAT Format;
    public uint InputSlot;
    public uint AlignedByteOffset;
    public D3D12_INPUT_CLASSIFICATION InputSlotClass;
    public uint InstanceDataStepRate;
}
