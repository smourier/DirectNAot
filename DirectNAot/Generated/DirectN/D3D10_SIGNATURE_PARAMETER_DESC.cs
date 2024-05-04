#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10shader/ns-d3d10shader-d3d10_signature_parameter_desc
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D10_SIGNATURE_PARAMETER_DESC
{
    public PSTR SemanticName;
    public uint SemanticIndex;
    public uint Register;
    public D3D_NAME SystemValueType;
    public D3D_REGISTER_COMPONENT_TYPE ComponentType;
    public byte Mask;
    public byte ReadWriteMask;
}
