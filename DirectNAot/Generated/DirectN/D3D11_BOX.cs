#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/ns-d3d11-d3d11_box
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D11_BOX
{
    public uint left;
    public uint top;
    public uint front;
    public uint right;
    public uint bottom;
    public uint back;
}
