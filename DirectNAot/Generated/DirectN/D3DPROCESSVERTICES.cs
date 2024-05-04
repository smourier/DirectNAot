#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct D3DPROCESSVERTICES
{
    public uint dwFlags;
    public ushort wStart;
    public ushort wDest;
    public uint dwCount;
    public uint dwReserved;
}
