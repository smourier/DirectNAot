#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/direct3d9/d3dlocked-rect
[StructLayout(LayoutKind.Sequential)]
public partial struct D3DLOCKED_RECT
{
    public int Pitch;
    public nint pBits;
}
