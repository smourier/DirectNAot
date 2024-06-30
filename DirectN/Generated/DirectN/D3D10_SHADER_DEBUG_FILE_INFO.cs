#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10_1shader/ns-d3d10_1shader-d3d10_shader_debug_file_info
public partial struct D3D10_SHADER_DEBUG_FILE_INFO
{
    public uint FileName;
    public uint FileNameLen;
    public uint FileData;
    public uint FileLen;
}
