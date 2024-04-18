namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11shader/ns-d3d11shader-d3d11_shader_variable_desc
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D11_SHADER_VARIABLE_DESC
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
