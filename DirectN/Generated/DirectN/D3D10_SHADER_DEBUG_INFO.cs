﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10_1shader/ns-d3d10_1shader-d3d10_shader_debug_info
public partial struct D3D10_SHADER_DEBUG_INFO
{
    public uint Size;
    public uint Creator;
    public uint EntrypointName;
    public uint ShaderTarget;
    public uint CompileFlags;
    public uint Files;
    public uint FileInfo;
    public uint Instructions;
    public uint InstructionInfo;
    public uint Variables;
    public uint VariableInfo;
    public uint InputVariables;
    public uint InputVariableInfo;
    public uint Tokens;
    public uint TokenInfo;
    public uint Scopes;
    public uint ScopeInfo;
    public uint ScopeVariables;
    public uint ScopeVariableInfo;
    public uint UintOffset;
    public uint StringOffset;
}
