#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10effect/ns-d3d10effect-d3d10_effect_type_desc
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D10_EFFECT_TYPE_DESC
{
    public PSTR TypeName;
    public D3D_SHADER_VARIABLE_CLASS Class;
    public D3D_SHADER_VARIABLE_TYPE Type;
    public uint Elements;
    public uint Members;
    public uint Rows;
    public uint Columns;
    public uint PackedSize;
    public uint UnpackedSize;
    public uint Stride;
}
