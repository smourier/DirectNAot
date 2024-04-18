namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/ns-d3d11-d3d11_input_element_desc
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D11_INPUT_ELEMENT_DESC
{
    public PSTR SemanticName;
    public uint SemanticIndex;
    public DXGI_FORMAT Format;
    public uint InputSlot;
    public uint AlignedByteOffset;
    public D3D11_INPUT_CLASSIFICATION InputSlotClass;
    public uint InstanceDataStepRate;
}
