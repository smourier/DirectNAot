#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_raytracing_shader_config
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_RAYTRACING_SHADER_CONFIG
{
    public uint MaxPayloadSizeInBytes;
    public uint MaxAttributeSizeInBytes;
}
