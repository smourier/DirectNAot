#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11shadertracing/ns-d3d11shadertracing-d3d11_trace_step
public partial struct D3D11_TRACE_STEP
{
    public uint ID;
    public BOOL InstructionActive;
    public byte NumRegistersWritten;
    public byte NumRegistersRead;
    public ushort MiscOperations;
    public uint OpcodeType;
    public ulong CurrentGlobalCycle;
}
