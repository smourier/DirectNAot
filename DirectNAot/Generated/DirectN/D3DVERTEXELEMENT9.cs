#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/direct3d9/d3dvertexelement9
[StructLayout(LayoutKind.Sequential)]
public partial struct D3DVERTEXELEMENT9
{
    public ushort Stream;
    public ushort Offset;
    public byte Type;
    public byte Method;
    public byte Usage;
    public byte UsageIndex;
}
