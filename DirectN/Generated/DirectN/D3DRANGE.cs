#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/direct3d9/d3drange
[StructLayout(LayoutKind.Sequential)]
public partial struct D3DRANGE
{
    public uint Offset;
    public uint Size;
}
