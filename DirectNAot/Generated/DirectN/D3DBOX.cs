namespace DirectN;

// https://learn.microsoft.com/windows/win32/direct3d9/d3dbox
[StructLayout(LayoutKind.Sequential)]
public partial struct D3DBOX
{
    public uint Left;
    public uint Top;
    public uint Right;
    public uint Bottom;
    public uint Front;
    public uint Back;
}
