#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12shader/ns-d3d12shader-d3d12_shader_variable_desc
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_SHADER_VARIABLE_DESC
{
    public PSTR Name;
    public uint StartOffset;
    public uint Size;
    public uint uFlags;
    public nint DefaultValue;
    public uint StartTexture;
    public uint TextureSize;
    public uint StartSampler;
    public uint SamplerSize;
}
