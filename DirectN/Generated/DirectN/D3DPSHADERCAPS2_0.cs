#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d9caps/ns-d3d9caps-d3dpshadercaps2_0
public partial struct D3DPSHADERCAPS2_0
{
    public uint Caps;
    public int DynamicFlowControlDepth;
    public int NumTemps;
    public int StaticFlowControlDepth;
    public int NumInstructionSlots;
}
