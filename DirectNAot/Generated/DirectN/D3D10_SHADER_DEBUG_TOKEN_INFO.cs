#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10_1shader/ns-d3d10_1shader-d3d10_shader_debug_token_info
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D10_SHADER_DEBUG_TOKEN_INFO
{
    public uint File;
    public uint Line;
    public uint Column;
    public uint TokenLength;
    public uint TokenId;
}
