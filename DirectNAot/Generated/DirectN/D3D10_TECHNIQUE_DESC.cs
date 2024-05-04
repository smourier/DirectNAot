#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10effect/ns-d3d10effect-d3d10_technique_desc
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D10_TECHNIQUE_DESC
{
    public PSTR Name;
    public uint Passes;
    public uint Annotations;
}
