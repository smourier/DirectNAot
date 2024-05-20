#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12shader/ns-d3d12shader-d3d12_signature_parameter_desc
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_SIGNATURE_PARAMETER_DESC
{
    public PSTR SemanticName;
    public uint SemanticIndex;
    public uint Register;
    public D3D_NAME SystemValueType;
    public D3D_REGISTER_COMPONENT_TYPE ComponentType;
    public byte Mask;
    public byte ReadWriteMask;
    public uint Stream;
    public D3D_MIN_PRECISION MinPrecision;
}
