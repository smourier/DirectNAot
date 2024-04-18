namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d9caps/ns-d3d9caps-d3dvshadercaps2_0
[StructLayout(LayoutKind.Sequential)]
public partial struct D3DVSHADERCAPS2_0
{
    public uint Caps;
    public int DynamicFlowControlDepth;
    public int NumTemps;
    public int StaticFlowControlDepth;
}
