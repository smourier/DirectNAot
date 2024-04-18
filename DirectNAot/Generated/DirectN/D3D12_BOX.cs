namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_box
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_BOX
{
    public uint left;
    public uint top;
    public uint front;
    public uint right;
    public uint bottom;
    public uint back;
}
