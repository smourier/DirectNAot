#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10effect/ns-d3d10effect-d3d10_effect_variable_desc
public partial struct D3D10_EFFECT_VARIABLE_DESC
{
    public PSTR Name;
    public PSTR Semantic;
    public uint Flags;
    public uint Annotations;
    public uint BufferOffset;
    public uint ExplicitBindPoint;
}
