#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/direct3d9/d3dcomposerectdesc
[StructLayout(LayoutKind.Sequential)]
public partial struct D3DCOMPOSERECTDESC
{
    public ushort X;
    public ushort Y;
    public ushort Width;
    public ushort Height;
}
