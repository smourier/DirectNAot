#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10/ns-d3d10-d3d10_box
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D10_BOX
{
    public uint left;
    public uint top;
    public uint front;
    public uint right;
    public uint bottom;
    public uint back;
}
