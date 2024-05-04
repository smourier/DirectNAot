#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10shader/ns-d3d10shader-d3d10_shader_variable_desc
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D10_SHADER_VARIABLE_DESC
{
    public PSTR Name;
    public uint StartOffset;
    public uint Size;
    public uint uFlags;
    public nint DefaultValue;
}
