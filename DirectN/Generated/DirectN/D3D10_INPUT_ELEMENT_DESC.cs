#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10/ns-d3d10-d3d10_input_element_desc
public partial struct D3D10_INPUT_ELEMENT_DESC
{
    public PSTR SemanticName;
    public uint SemanticIndex;
    public DXGI_FORMAT Format;
    public uint InputSlot;
    public uint AlignedByteOffset;
    public D3D10_INPUT_CLASSIFICATION InputSlotClass;
    public uint InstanceDataStepRate;
}
