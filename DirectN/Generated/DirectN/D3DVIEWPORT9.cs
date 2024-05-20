#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/direct3d9/d3dviewport9
[StructLayout(LayoutKind.Sequential)]
public partial struct D3DVIEWPORT9
{
    public uint X;
    public uint Y;
    public uint Width;
    public uint Height;
    public float MinZ;
    public float MaxZ;
}
